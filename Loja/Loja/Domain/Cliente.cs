﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Loja.Domain
{
    class Cliente : Pessoa
    {
        [Key]
        public int Id { get; set; }
    }
}
