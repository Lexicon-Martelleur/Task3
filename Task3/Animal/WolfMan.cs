using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animal;

internal class WolfMan : Wolf, IPerson
{
    internal WolfMan(
        string name,
        double weight,
        double age,
        double runningSpeed) : base(name, weight, age, runningSpeed) { }

    public string Talk() {  return "I can talk with animals"; }
}
