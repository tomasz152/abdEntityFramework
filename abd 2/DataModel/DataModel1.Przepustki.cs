﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 14.11.2017 23:49:49
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace abdModel
{
    public partial class Przepustki {

        public Przepustki()
        {
            OnCreated();
        }

        public virtual int IDPrzepustki
        {
            get;
            set;
        }

        public virtual System.DateTime DataRozpoczecia
        {
            get;
            set;
        }

        public virtual System.DateTime DataZakonczenia
        {
            get;
            set;
        }

        public virtual int WykorzystanePunkty
        {
            get;
            set;
        }

        public virtual int NrSprawy
        {
            get;
            set;
        }

        public virtual Wyrok Wyrok
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
