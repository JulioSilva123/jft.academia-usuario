using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace jft.academia.v01.Core.Entities
{
    public class Itens_Diaria
    {


        [PrimaryKey, AutoIncrement]
        public int id_item_diaria { get; set; }

        public int id_diaria { get; set; }

        public int id_item_atividade { get; set; }





        public int nr_ordem { get; set; }

        public int nr_posicao_pino { get; set; }

        public int nr_peso { get; set; }

        public int nr_repeticao { get; set; }

        public string te_descricao { get; set; }

        public DateTime dt_item_diaria { get; set; }

        public bool bo_item_diaria_concluido { get; set; }

    }
}
