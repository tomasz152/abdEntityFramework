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
    public partial class Zajecia {

        public Zajecia()
        {
            this.Harmonograms = new List<Harmonogram>();
            OnCreated();
        }

        public virtual int IDZajecia
        {
            get;
            set;
        }

        public virtual int Punkty
        {
            get;
            set;
        }

        public virtual string Opis
        {
            get;
            set;
        }

        public virtual IList<Harmonogram> Harmonograms
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
