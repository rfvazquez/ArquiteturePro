using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace AutoUpdate
{
    class Program
    {
        public static string _executableName = "ArchitecturePro.exe";
        static void Main(string[] args)
        {
            var localArquivo = args[0];
            //var localArquivo = "https://drive.google.com/uc?authuser=0&id=1X1XCwjjtfOOQ4Ix0iFw5QrW5iYj_H7EA&export=download";

            try
            {
                Console.WriteLine("Atualizando o Sistema. Por favor, Aguarde....");
                Console.WriteLine($"Procurando arquivo em: {localArquivo}");
                using (var client = new WebClient())
                {
                    client.DownloadFile(localArquivo, "update.zip");
                }
                ExtractUpdate($"update.zip");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao tentar executar o sistema: {ex.Message}");
            }
            StartProcess();
        }


        static void ExtractUpdate(string localUpdateFile)
        {
            try
            {
                var zip = new FastZip();
                zip.ExtractZip(localUpdateFile, AppDomain.CurrentDomain.BaseDirectory, FastZip.Overwrite.Always, null, null, null, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Falha ao copiar arquivos.\r\nOrigem: {0}\r\nDestino: {1}\r\n\r\nErro: {2}\r\n\r\nPressione qualquer tecla para continuar...", localUpdateFile, "update.zip", ex.Message));
                Console.ReadKey();
            }
        }

        static void StartProcess()
        {
            try
            {

                var rstrui = new System.Diagnostics.ProcessStartInfo();
                var executableInfo = new FileInfo(_executableName);
                rstrui.FileName = Regex.Replace(executableInfo.Name, ".exe", string.Empty, RegexOptions.IgnoreCase) + ".exe";
                rstrui.UseShellExecute = true;
                rstrui.Verb = "runas"; //O segredo é esta linha by Lucas e Fernando!
                rstrui.WorkingDirectory = Environment.CurrentDirectory;
                System.Diagnostics.Process.Start(rstrui);

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Falha ao iniciar o arquivo. Arquivo: {0}\r\n\r\nErro: {1}\r\n\r\nPressione qualquer tecla para continuar...", _executableName, ex.Message));
                Console.ReadKey();
            }
        }

    }
}
