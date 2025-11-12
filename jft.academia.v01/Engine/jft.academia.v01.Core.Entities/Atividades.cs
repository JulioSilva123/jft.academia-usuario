using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace jft.academia.v01.Core.Entities
{
    public class Atividades
    {
        [PrimaryKey, AutoIncrement]
        public int id_atividade { get; set; }

        public string nm_atividade { get; set; }

        public string te_descricao { get; set; }
    }
}
