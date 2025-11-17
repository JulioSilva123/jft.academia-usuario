using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace jft.academia.v01.Core.Entities
{
    public class Diarias
    {

        [PrimaryKey, AutoIncrement]
        public int id_diaria { get; set; }




        public int id_atividade { get; set; }

        public int id_grupo_atividade { get; set; }

        public int nr_ordem { get; set; }






        public string nm_diaria { get; set; }


        public string te_descricao { get; set; }


        public DateTime dt_diaria { get; set; }


        public bool bo_diaria_concluido { get; set; }




    }
}
