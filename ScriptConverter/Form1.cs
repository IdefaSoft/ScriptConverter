using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ScriptConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class AssemblyMetadata
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string FileVersion { get; set; }
            public string ProductVersion { get; set; }
            public string ProductName { get; set; }
            public string Company { get; set; }
            public string Copyright { get; set; }
            public string Trademark { get; set; }

            public string GenerateAssemblyInfo()
            {
                StringBuilder assemblyInfo = new StringBuilder()
                    .AppendLine()
                    .AppendLine("using System.Reflection;")
                    .AppendLine("using System.Runtime.InteropServices;")
                    .AppendLine();

                AppendIfNotEmpty(assemblyInfo, Title, "AssemblyTitle");
                AppendIfNotEmpty(assemblyInfo, Description, "AssemblyDescription");
                AppendIfNotEmpty(assemblyInfo, FileVersion, "AssemblyFileVersion");
                AppendIfNotEmpty(assemblyInfo, ProductVersion, "AssemblyInformationalVersion");
                AppendIfNotEmpty(assemblyInfo, ProductName, "AssemblyProduct");
                AppendIfNotEmpty(assemblyInfo, Company, "AssemblyCompany");
                AppendIfNotEmpty(assemblyInfo, Copyright, "AssemblyCopyright");
                AppendIfNotEmpty(assemblyInfo, Trademark, "AssemblyTrademark");

                assemblyInfo
                    .AppendLine("[assembly: ComVisible(false)]")
                    .AppendLine($"[assembly: Guid(\"{Guid.NewGuid()}\")]");

                return assemblyInfo.ToString();
            }
            private static void AppendIfNotEmpty(StringBuilder sb, string value, string attribute)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    sb.AppendLine($"[assembly: {attribute}(\"{value}\")]");
                }
            }
        }

        private AssemblyMetadata GetAssemblyMetadata()
        {
            return new AssemblyMetadata
            {
                Title = chkTitle.Checked ? txtTitle.Text : null,
                Description = chkDescription.Checked ? txtDescription.Text : null,
                FileVersion = chkFileVersion.Checked ? txtFileVersion.Text : null,
                ProductVersion = chkProductVersion.Checked ? txtProductVersion.Text : null,
                ProductName = chkProductName.Checked ? txtProductName.Text : null,
                Company = chkCompany.Checked ? txtCompany.Text : null,
                Copyright = chkCopyright.Checked ? txtCopyright.Text : null,
                Trademark = chkTrademark.Checked ? txtTrademark.Text : null
            };
        }

        private static string EncryptString(string text, string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(salt);

            using (var derive = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] key = derive.GetBytes(32);
                byte[] iv = derive.GetBytes(16);

                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (var encryptor = aes.CreateEncryptor())
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(salt, 0, salt.Length);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(text);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        private static string GetDecryptionCode()
        {
            return @"
        private static string DecryptScript(string encryptedText, string password)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            
            byte[] salt = new byte[16];
            Array.Copy(encryptedBytes, 0, salt, 0, 16);

            using (var derive = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] key = derive.GetBytes(32);
                byte[] iv = derive.GetBytes(16);

                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (var decryptor = aes.CreateDecryptor())
                    using (var ms = new MemoryStream(encryptedBytes, 16, encryptedBytes.Length - 16))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }";
        }

        private static string GetPasswordFormCode()
        {
            return @"
        private static string ShowPasswordDialog()
        {
            using(var form = new Form())
            {
                form.Width = 300;
                form.Height = 135;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.Text = ""Enter Password"";
                form.StartPosition = FormStartPosition.CenterScreen;

                TextBox textBox = new TextBox() { Left = 27, Top = 20, Width = 240, PasswordChar = '*', MaxLength = 64 };
                Button button = new Button() { Text = ""Submit"", Left = 117, Top = 60, DialogResult = DialogResult.OK, Width = 60 };
                
                form.Controls.Add(textBox);
                form.Controls.Add(button);
                form.AcceptButton = button;

                return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }";
        }

        private static string GetAdminCheckCode()
        {
            return @"
        if (!new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()).IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                UseShellExecute = true,
                Verb = ""runas""
            };
            try
            {
                Process.Start(startInfo);
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Environment.Exit(1);
            }
        }";
        }

        private static string GetSelfDeleteCode()
        {
            return @"
        ProcessStartInfo psi2 = new ProcessStartInfo
        {
            FileName = ""cmd.exe"",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden,
            Arguments = ""/c ping localhost -n 3 > NUL && del /A H /F \"""" + Process.GetCurrentProcess().MainModule.FileName + ""\""""
        };
        Process.Start(psi2);";
        }

        private static string GetProcessConfig(string fileType)
        {
            if (fileType == "bat")
            {
                return @"
        psi.FileName = tempPath;
        psi.UseShellExecute = true;";
            }
            else if (fileType == "vbs")
            {
                return @"
        psi.FileName = ""cscript.exe"";
        psi.Arguments = tempPath;";
            }
            else
            {
                return @"
        psi.FileName = ""powershell.exe"";
        psi.Arguments = ""-ExecutionPolicy Bypass -File "" + tempPath;";
            }
        }

        private static string GetPasswordCheckCode(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            return $@"
        string password = ShowPasswordDialog();
        if (String.Concat(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)).Select(item => item.ToString(""x2""))) != ""{string.Concat(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)).Select(item => item.ToString("x2")))}"")
        {{
            MessageBox.Show(""The password you entered is invalid."", ""Invalid Password"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }}";
        }

        private static string GenerateWrapperCode(
            string script,
            bool requireAdmin,
            bool showConsole,
            bool encrypt,
            string password,
            bool deleteAfterRun,
            string fileType)
        {
            string adminCheck = requireAdmin ? GetAdminCheckCode() : "";
            string passwordCheck = GetPasswordCheckCode(password);
            string encodedScript = encrypt ? EncryptString(script, password ?? "default") : Convert.ToBase64String(Encoding.UTF8.GetBytes(script));
            string decryptionCode = encrypt
                ? $"        script = DecryptScript(script, {(!string.IsNullOrEmpty(password) ? "password" : "\"default\"")});"
                : "        script = Encoding.UTF8.GetString(Convert.FromBase64String(script));";
            string selfDelete = deleteAfterRun ? GetSelfDeleteCode() : "";
            string additionalFunctions = (!string.IsNullOrEmpty(password) ? GetPasswordFormCode() : "") + (encrypt ? GetDecryptionCode() : "");

            return $@"using System;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
{(string.IsNullOrEmpty(password) ? string.Empty : "using System.Linq;" + Environment.NewLine + "using System.Windows.Forms;")}
using System.Text;

public class ScriptRunner
{{
    [STAThread]
    public static void Main()
    {{
{adminCheck}
{passwordCheck}
        string script = ""{encodedScript}"";
{decryptionCode}
        string tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + "".{fileType}"");
        File.WriteAllText(tempPath, script);

        ProcessStartInfo psi = new ProcessStartInfo();
{GetProcessConfig(fileType)}
        psi.CreateNoWindow = {(!showConsole).ToString().ToLower()};
        psi.WindowStyle = {(showConsole ? "ProcessWindowStyle.Normal" : "ProcessWindowStyle.Hidden")};

        using(Process p = Process.Start(psi))
        {{
            p.WaitForExit();
        }}
        if(File.Exists(tempPath)) File.Delete(tempPath);
{selfDelete}
    }}
{additionalFunctions}
}}";
        }

        public void ConvertScript(
            string inputCode,
            string outputPath,
            string architecture,
            string iconPath,
            bool requireAdmin,
            bool showConsole,
            bool encrypt,
            string password,
            bool deleteAfterRun,
            string fileType,
            AssemblyMetadata metadata)
        {
            string wrapperCode = GenerateWrapperCode(inputCode, requireAdmin, showConsole, encrypt, password, deleteAfterRun, fileType);

            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = outputPath,
                TreatWarningsAsErrors = false,
                IncludeDebugInformation = false,
                CompilerOptions = "/optimize+ /target:winexe",
            };

            parameters.ReferencedAssemblies.Add("System.dll");
            if (!string.IsNullOrEmpty(password))
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                parameters.ReferencedAssemblies.Add("System.Core.dll");
            }

            if (!string.IsNullOrWhiteSpace(iconPath))
            {
                parameters.CompilerOptions += $" /win32icon:\"{iconPath}\"";
            }

            if (architecture == "64")
            {
                parameters.CompilerOptions += " /platform:x64";
            }
            else if (architecture == "32")
            {
                parameters.CompilerOptions += " /platform:x86";
            }

            if (metadata != null)
            {
                string assemblyInfo = metadata.GenerateAssemblyInfo();
                wrapperCode = wrapperCode.Insert(wrapperCode.IndexOf("using System.Text;") + 18, assemblyInfo);
            }

            using (CSharpCodeProvider provider = new CSharpCodeProvider())
            {
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, wrapperCode);

                if (results.Errors.HasErrors)
                {
                    StringBuilder errorMsg = new StringBuilder();
                    foreach (CompilerError error in results.Errors)
                    {
                        errorMsg.AppendLine($"Error (Line {error.Line}): {error.ErrorText}");
                    }

                    MessageBox.Show(errorMsg.ToString(), "Error while compiling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput(out string errorMessage, out string errorTitle)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                (errorMessage, errorTitle) = ("You didn't write any code!", "Code Missing");
                return false;
            }
            if (chkIcon.Checked && (!File.Exists(txtIcon.Text) || !txtIcon.Text.EndsWith(".ico", StringComparison.OrdinalIgnoreCase)))
            {
                (errorMessage, errorTitle) = ("Please choose a valid icon.", "Invalid Icon");
                return false;
            }
            if (!txtOutputFile.Text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            {
                (errorMessage, errorTitle) = ("Please choose a valid output file.", "Invalid Output");
                return false;
            }
            if (!Directory.Exists(Path.GetDirectoryName(txtOutputFile.Text)))
            {
                (errorMessage, errorTitle) = ("The output directory doesn't exist.", "Invalid Output Directory");
                return false;
            }
            if (File.Exists(txtOutputFile.Text))
            {
                DialogResult choice = MessageBox.Show("The output file already exists. Do you want to overwrite it?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choice == DialogResult.No)
                {
                    errorMessage = errorTitle = string.Empty;
                    return false;
                }
            }
            errorMessage = errorTitle = string.Empty;
            return true;
        }

        private string GetFileType()
        {
            if (rdoVbs.Checked) return "vbs";
            if (rdoPowershell.Checked) return "ps1";
            return "bat";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutputFile.Text = Path.Combine(Environment.CurrentDirectory, "output.exe");
            txtCopyright.Text = $"Copyright © {DateTime.Now.Year}";
        }

        private void TxtCode_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string extension = Path.GetExtension(files[0]).ToLower();
                    if (extension == ".bat" || extension == ".vbs" || extension == ".ps1" || extension == ".txt")
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void TxtCode_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                try
                {
                    string content = File.ReadAllText(files[0]);
                    txtCode.Text += Environment.NewLine + content;
                }
                catch { }
            }
        }

        private void BtnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Icon file (*.ico)|*.ico",
                Title = "Output File Icon",
                FilterIndex = 2,
                RestoreDirectory = true,
                CheckFileExists = true,
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = dialog.FileName;
            }
        }

        private void BtnOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Executable file (*.exe)|*.exe",
                Title = "Output File Location",
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = "output.exe"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = dialog.FileName;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string errorMessage, out string errorTitle))
            {
                ConvertScript(
                    txtCode.Text,
                    txtOutputFile.Text,
                    rdo64bits.Checked ? "64" : "32",
                    chkIcon.Checked ? txtIcon.Text : null,
                    chkRequestAdminPrivileges.Checked,
                    !chkHideConsole.Checked,
                    chkEncryption.Checked,
                    chkAskForPassword.Checked ? txtPassword.Text : null,
                    chkDeleteAfterRun.Checked,
                    GetFileType(),
                    GetAssemblyMetadata()
                );
                MessageBox.Show("Conversion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
