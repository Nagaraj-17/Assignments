﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2Assignments
{
    class ConvertTabular

                string[] rows = File.ReadAllLines(filePath);


                if (rows.Length > 0)

                for (int row = 1; row < rows.Length; row++)