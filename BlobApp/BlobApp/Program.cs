using System;
using System.IO;
using Azure.Storage.Blobs;

namespace BlobApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create connection string from storage account access key
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=mimresource;AccountKey=ttNaW9+cgWAnDze4SazLkBhJtgREfn1WHNLOVrKnFGkDRd8x/9fgb6YIJldR0oSzqOo8wcYn8mvEPEaPyfySvA==;EndpointSuffix=core.windows.net";

            //Install the blobs package: Install-Package Azure.Storage.Blobs e incluir no código
            //Criar um cliente de conta de armazenamento
            BlobServiceClient  blobServiceClient = new BlobServiceClient(connectionString);

            //Criar o nome de container em caixa baixa
            string container = "exemplo-aula-blob";
            //Criar o container, caso não exista
            BlobContainerClient blobContainerClient = blobServiceClient.CreateBlobContainer(container);
            blobContainerClient.CreateIfNotExists();

            //Criar as referências para o arquivo (blob)
            string diretorio = "c:/Users/iasmi/OneDrive/AreadeTrabalho/download.jpg";
            string arquivo = "download.jpg";
            string caminhoArquivo = Path.Combine(diretorio, arquivo);

            string arquivo2 = "iasmim.pdf";
            string caminhoArquivo2 = Path.Combine(diretorio, arquivo2);

            //Associar o arquivo ao container
            BlobClient blobClient = blobContainerClient.GetBlobClient(arquivo);
            Console.WriteLine($"Upload para {blobContainerClient.Uri}");

            //Realizar o upload do arquivo
            //FileStream upload = File.OpenRead(caminhoArquivo);
            //blobClient.Upload(upload);
            //upload.Close();
            //Console.WriteLine($"Upload para {blobClient.Uri}");
        }

    }
}
