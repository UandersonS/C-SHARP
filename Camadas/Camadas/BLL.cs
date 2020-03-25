using System.Data;

namespace Camadas
{
    public class CamadaLogicaNegocios
    {
        public DataSet ObtemClientes()
        {
            CamadaAcessoDados dal = new CamadaAcessoDados();
            return dal.RetornaDataSet("select * from Clientes");
        }
    }
}