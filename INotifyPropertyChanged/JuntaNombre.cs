﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadINotify
{
    public class JuntaNombre : INotifyPropertyChanged
    {

        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                nombre = value;
                OnPropertyChanged("Nombre_completo");
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged("Nombre_completo");
            }
        }

        public string Nombre_completo
        {
            get
            {
                nombre_completo = nombre + " " + Apellido;
                return nombre_completo;
            }

            set { }
        }
    }
}
