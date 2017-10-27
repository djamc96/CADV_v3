using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cadv
{
    class txt
    {
        //Essa função é pra criar uma arquivo txt, ele recebe com parametro o nome do arquivo
        public void criartxt(string nometxt)
        {
            if (!File.Exists(nometxt))
            {
                File.Create(nometxt).Close();
                //MessageBox.Show("Arquivo criado com sucesso");
            }
            else
            {
                File.Delete(nometxt);
                File.Create(nometxt).Close();
                //MessageBox.Show("Arquivo criado com sucesso");
            }
        }

        public void instanciar(string nometxt) 
        {
            if (File.Exists(nometxt))
            {
                writer = new StreamWriter(nometxt);
            }
        }

        //Essa função escreve em apenas uma linha, recebe como parametro o nome do arquivo e o dado que vai ser escrito
        public void escrevertxt( string linha) 
        {
            {
                writer.WriteLine(linha);
            }
        }

        public void fechartxt()
        {
            writer.Close();
        }

        public string lertxt(string nometxt, int nlinha) 
        {
            //cria uma lista para armazenar os dados encontrados no documento
            List<string> dados = new List<string>();
            //declara uma variável para receber linha por linha do doc
            string linha;
            //verifica se existe um doc com o nome passado ates de fazer a leitura
            if (File.Exists(nometxt))
            {
                //usa uma biblioteca chamada StreamReader para fazer a leitura do arquivo baseado no caminho informado
                using (StreamReader reader = new StreamReader(nometxt))
                {
                    //cria um loop para adicionar linha por linha do doc até sua ultima linha
                    while ((linha = reader.ReadLine()) != null)
                    {
                        //adiciona linha a linha a nossa lista de dados
                        dados.Add(linha);
                    }
                }
                /*
                for (int i = 0; i < dados.Count; i++)
                {
                     test += dados[i].ToString() + "\n";
                }
                MessageBox.Show(dados.Count+test);*/
                return dados[nlinha].ToString();
            }
            else
            {
                //caso não encontre nenhum registro da a mensagem abaixo
                MessageBox.Show("Nenhum registro encontrado!", "Lendo Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool exi_txt(string nometxt)
        {
            if (File.Exists(nometxt)) return true;
            else return false;
        }

        public StreamWriter writer { get; set; }
    }
}
