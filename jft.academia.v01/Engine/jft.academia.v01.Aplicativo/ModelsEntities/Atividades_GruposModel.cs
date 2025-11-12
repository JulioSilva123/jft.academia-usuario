using System;
using System.Collections.Generic;
using System.Text;

namespace jft.academia.v01.Aplicativo.ModelsEntities
{
    public class Atividades_GruposModel
    {

        public int id_atividade_grupo { get; set; }
        public int id_atividade { get; set; }
        public int id_grupo_atividade { get; set; }        
        public int nr_ordem { get; set; }
        public string te_descricao { get; set; }


    }
}
