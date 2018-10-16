using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ArchitecturePro.Util
{
    public class ArquivosGoogleDrive
    {
        public System.Drawing.Image Imagem { set; get; }
        public string Nome { set; get; }
        public string Tipo { set; get; }

    }


    public static class GoogleDrive
    {

        private static Google.Apis.Drive.v3.DriveService _servico = null;

        public static bool CriarServicoGoogleDrive()
        {
            var ret = true;
            try
            {
                _servico = GoogleDrive.AbrirServico(GoogleDrive.Autenticar());
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        public static void CriaDiretorio(string nome)
        {
            var idPasta = BuscaIdPasta(_servico, nome);
            if (String.IsNullOrEmpty(idPasta))
            {
                GoogleDrive.CriarDiretorio(_servico, nome);
            }
        }

        public static bool Upload(string caminho, string pasta)
        {
            var ret = true;
            try
            {
                GoogleDrive.Upload(_servico, caminho, pasta);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }
        public static bool Download(string nomeArquivo, string destinoArquivo)
        {
            var ret = true;
            try
            {
                Download(_servico, nomeArquivo, destinoArquivo);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        public static bool DeleteArquivo(string nomeArquivo)
        {
            var ret = true;
            try
            {
                DeletarItem(_servico, nomeArquivo);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        public static List<ArquivosGoogleDrive> ListarArquivos(string nomePasta)
        {
            return ListarArquivos(_servico, nomePasta);
        }

        private static Google.Apis.Auth.OAuth2.UserCredential Autenticar()
        {
            Google.Apis.Auth.OAuth2.UserCredential credenciais = null;
            try
            {
                using (var stream = new System.IO.FileStream("./credential/client_id.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    var diretorioAtual = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    var diretorioCredenciais = System.IO.Path.Combine(diretorioAtual, "credential");

                    credenciais = Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker.AuthorizeAsync(
                        Google.Apis.Auth.OAuth2.GoogleClientSecrets.Load(stream).Secrets,
                        new[] { Google.Apis.Drive.v3.DriveService.Scope.Drive },
                        "user",
                        System.Threading.CancellationToken.None,
                        new Google.Apis.Util.Store.FileDataStore(diretorioCredenciais, true)).Result;
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return credenciais;
        }

        private static Google.Apis.Drive.v3.DriveService AbrirServico(Google.Apis.Auth.OAuth2.UserCredential credenciais)
        {
            return new Google.Apis.Drive.v3.DriveService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credenciais
            });
        }

        private static string BuscaIdPasta(Google.Apis.Drive.v3.DriveService servico, string nomePasta)
        {
            var idPasta = "";
            try
            {
                if (!String.IsNullOrEmpty(nomePasta))
                {
                    var pastas = ProcurarArquivoId(servico, nomePasta);
                    if (pastas.Length > 0)
                    {
                        idPasta = pastas[0];
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idPasta;
        }

        private static Image BuscaImagemUrl(string url)
        {
            Image ret = null;
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    ret = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro ao recuperar imagem do arquivo Google Drive", "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;

        }


        private static List<ArquivosGoogleDrive> ListarArquivos(Google.Apis.Drive.v3.DriveService servico, string nomePasta)
        {
            var ret = new List<ArquivosGoogleDrive>();

            try
            {
                var request = servico.Files.List();

                var idPasta = BuscaIdPasta(servico, nomePasta);
                if (!String.IsNullOrEmpty(idPasta))
                {
                    request.Q = string.Format("'{0}' in parents", idPasta);
                }
                request.Fields = "files(id, name, parents, iconLink, fileExtension)";

                var resultado = request.Execute();
                var arquivos = resultado.Files;

                if (arquivos != null && arquivos.Any())
                {
                    foreach (var arquivo in arquivos)
                    {
                        var arquivoRecuperado = new ArquivosGoogleDrive()
                        {
                            Nome = arquivo.Name,
                            Tipo = arquivo.FileExtension,
                            Imagem = BuscaImagemUrl(arquivo.IconLink)
                        };
                        ret.Add(arquivoRecuperado);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }


        private static void ListarArquivosPaginados(Google.Apis.Drive.v3.DriveService servico, int arquivosPorPagina)
        {
            var request = servico.Files.List();
            request.Fields = "nextPageToken, files(id, name)";
            //request.Q = "trashed=false";
            // Default 100, máximo 1000.
            request.PageSize = arquivosPorPagina;
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            while (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    Console.WriteLine(arquivo.Name);
                }

                if (resultado.NextPageToken != null)
                {
                    Console.WriteLine("Digite ENTER para ir para a próxima página");
                    Console.ReadLine();
                    request.PageToken = resultado.NextPageToken;
                    resultado = request.Execute();
                    arquivos = resultado.Files;
                }
                else
                {
                    arquivos = null;
                }
            }
        }

        private static void CriarDiretorio(Google.Apis.Drive.v3.DriveService servico, string nomeDiretorio)
        {
            try
            {
                var diretorio = new Google.Apis.Drive.v3.Data.File();
                diretorio.Name = nomeDiretorio;
                diretorio.MimeType = "application/vnd.google-apps.folder";
                var request = servico.Files.Create(diretorio);
                request.Execute();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro Google Drive: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static string[] ProcurarArquivoId(Google.Apis.Drive.v3.DriveService servico, string nome, bool procurarNaLixeira = false)
        {
            var retorno = new List<string>();

            var request = servico.Files.List();
            request.Q = string.Format("name = '{0}'", nome);
            if (!procurarNaLixeira)
            {
                request.Q += " and trashed = false";
            }
            request.Fields = "files(id)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    retorno.Add(arquivo.Id);
                }
            }

            return retorno.ToArray();
        }

        private static void DeletarItem(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    var request = servico.Files.Delete(id);
                    request.Execute();
                }
            }
        }

        private static void Upload(Google.Apis.Drive.v3.DriveService servico, string caminhoArquivo, string nomePasta)
        {

            var arquivo = new Google.Apis.Drive.v3.Data.File();
            arquivo.Name = System.IO.Path.GetFileName(caminhoArquivo);
            arquivo.MimeType = MimeTypes.MimeTypeMap.GetMimeType(System.IO.Path.GetExtension(caminhoArquivo));

            //Aqui vamos colocar o arquivo dentro da pasta
            var idPasta = BuscaIdPasta(servico, nomePasta);
            if (!String.IsNullOrEmpty(idPasta))
            {
                arquivo.Parents = new List<string> { idPasta };
            }

            using (var stream = new System.IO.FileStream(caminhoArquivo, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var ids = ProcurarArquivoId(servico, arquivo.Name);
                Google.Apis.Upload.ResumableUpload<Google.Apis.Drive.v3.Data.File, Google.Apis.Drive.v3.Data.File> request;

                if (ids == null || !ids.Any())
                {
                    request = servico.Files.Create(arquivo, stream, arquivo.MimeType);
                }
                else
                {
                    request = servico.Files.Update(arquivo, ids.First(), stream, arquivo.MimeType);
                }

                request.Upload();
            }
        }

        private static void Download(Google.Apis.Drive.v3.DriveService servico, string nome, string destino)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                var request = servico.Files.Get(ids.First());
                using (var stream = new System.IO.FileStream(destino, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    request.Download(stream);
                }
            }
        }

        private static void MoverParaLixeira(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    var arquivo = new Google.Apis.Drive.v3.Data.File();
                    arquivo.Trashed = true;
                    var request = servico.Files.Update(arquivo, id);
                    request.Execute();
                }
            }
        }

    }
}
