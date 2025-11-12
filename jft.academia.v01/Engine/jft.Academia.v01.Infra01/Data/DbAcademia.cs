
namespace jft.Academia.v01.Infra01.Data
{


    public class DbAcademia
    {


        public DbAcademia()
        {

        }



        private Data.Repositorys.GruposReporitory _Grupos;
        public Data.Repositorys.GruposReporitory Grupos
        {
            get
            {
                if (_Grupos is null)
                {
                    _Grupos = new Data.Repositorys.GruposReporitory();
                }

                return _Grupos;

            }
        }


        private Data.Repositorys.AtividadesReporitory _Atividades;
        public Data.Repositorys.AtividadesReporitory Atividades
        {
            get
            {
                if (_Atividades is null)
                {
                    _Atividades = new Data.Repositorys.AtividadesReporitory();
                }

                return _Atividades;

            }
        }
    }


}