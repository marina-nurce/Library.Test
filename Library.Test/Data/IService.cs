﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test.Data
{
    public  interface  IService
    {
        string GetAll();
        string Get(int id);
        void Example();

        void NewMethod();
        }
    }


