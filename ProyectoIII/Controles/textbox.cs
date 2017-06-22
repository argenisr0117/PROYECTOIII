﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIII.Controles
{
    public partial class textbox : TextBox
    {
        System.Drawing.FontFamily obj = new System.Drawing.FontFamily("Verdana");
        public textbox()
        {
            InitializeComponent();
        }
        public bool Validar
        {
            set;
            get;
        }
        public textbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
