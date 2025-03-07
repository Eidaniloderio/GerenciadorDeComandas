﻿using GerenciadorDeComandas.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConexaoBanco conexaoBanco = new ConexaoBanco();
            conexaoBanco.IniciarTabelas();
            
            Application.Run(new FrmPrincipal());
        }
    }
}
