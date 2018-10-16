﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewFormaPagamento
    {
        public int Id { set; get; }
        public DateTime Data { set; get; }
        public Decimal Valor { set; get; }
        public bool PagSeguro { set; get; }
        public bool PagamentoConfirmado { set; get; }
        public string UrlPagamento { set; get; }
    }
}
