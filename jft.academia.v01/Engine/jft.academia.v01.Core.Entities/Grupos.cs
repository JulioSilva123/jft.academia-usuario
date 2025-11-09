using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace jft.academia.v01.Core.Entities
{
    public class Grupos
    {
        [PrimaryKey, AutoIncrement]
        public int id_grupo_atividade { get; set; }
        public string nm_grupo_atividade { get; set; }
    }
}
