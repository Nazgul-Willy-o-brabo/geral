using System.Xml.Serialization;
using ClientesXML.entities;
using System.Xml.Linq;
using ClientesXML;
using System.Xml;

namespace ClientesXML.service
{
    [Serializable]
    public class ClientesDAO
    {
        public List<Cliente> Carregar(string path,DataGridView dataGridView)
        {
            List<Cliente> cliente = new List<Cliente>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                cliente = (List<Cliente>)serializer.Deserialize(fs);
            }
            dataGridView.DataSource = cliente;
            return cliente;
        }
        public void Salvar(string path, List<Cliente> cliente)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, cliente);
            }
        }
    }
}
