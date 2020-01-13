using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KiranFont
    {
        public int Sum(int n1,int n2)
        {
            return 1111;
        }
        public String KfPreprocess(String input)
        {
           input = input.Replace("x", "");
            input = input.Replace("&", "ja\\É");
            input = input.Replace("\u00C9", "É\\");
            input = input.Replace("X", "K\\Y");
            input = input.Replace("w", "L\\Y");
            input = input.Replace("F", "f\\Y");
            input = input.Replace("E", "S");
            input = input.Replace("H", "h\\");
            input = input.Replace("`", "\\r");
            input = input.Replace("^", "\\r");
            input = input.Replace("~", "tr\\");
            input = input.Replace("+", "h\\ya");
            input = input.Replace("$", "tt");
            input = input.Replace("%", "r\\ँ");
            
            

            return input; 
        }
        public Char KFKiran2Uni(Char strChar)
        {

            if (strChar.Equals('#')) { return 'ऽ'; }
            else
            if (strChar.Equals('*')) { return 'ॐ'; }
            else
            
            
            if (strChar.Equals('0')) { return '०'; }
            else
            if (strChar.Equals('1')) { return '१'; }
            else
            if (strChar.Equals('2')) { return '२'; }
            else
            if (strChar.Equals('3')) { return '३'; }
            else
            if (strChar.Equals('4')) { return '४'; }
            else
            if (strChar.Equals('5')) { return '५'; }
            else
            if (strChar.Equals('6')) { return '६'; }
            else
            if (strChar.Equals('7')) { return '७'; }
            else
            if (strChar.Equals('8')) { return '८'; }
            else
            if (strChar.Equals('9')) { return '९'; }
            else


            if (strChar.Equals('A')) { return 'अ'; }
            else
            if (strChar.Equals('B')) { return 'भ'; }
            else
            if (strChar.Equals('C')) { return 'छ'; }
            else
            if (strChar.Equals('D')) { return 'ड'; }
            else
            if (strChar.Equals('G')) { return 'घ'; }
            else
            if (strChar.Equals('I')) { return 'ी'; }
            else
            if (strChar.Equals('J')) { return 'झ'; }
            else
            if (strChar.Equals('K')) { return 'ख'; }
            else
            if (strChar.Equals('L')) { return 'ळ'; }
            else
            if (strChar.Equals('M')) { return 'ं'; }
            else
            if (strChar.Equals('N')) { return 'ण'; }
            else
            if (strChar.Equals('O')) { return 'ै'; }
            else
            if (strChar.Equals('P')) { return 'ऋ'; }
            else
            if (strChar.Equals('Q')) { return 'ध'; }
            else
            if (strChar.Equals('R')) { return 'ृ'; }
            else
            if (strChar.Equals('S')) { return 'श'; }
            else
            if (strChar.Equals('T')) { return 'ट'; }
            else
            if (strChar.Equals('V')) { return 'ॅ'; }
            else
            if (strChar.Equals('Y')) { return 'ष'; }
            else
            if (strChar.Equals('Z')) { return 'ढ'; }
            else
            if (strChar.Equals('[') ){ return 'इ'; }
            else
            if (strChar.Equals('\\')) { return '्'; }
            else
            if (strChar.Equals(']')) { return 'ु'; }
            else
            if (strChar.Equals('a')) { return 'ा'; }
            else
            if (strChar.Equals('b')) { return 'ब'; }
            else
            if (strChar.Equals('c')) { return 'च'; }
            else
            if (strChar.Equals('d')) { return 'द'; }
            else
            if (strChar.Equals('e')) { return 'ए'; }
            else
            if (strChar.Equals('f')) { return 'फ'; }
            else
            if (strChar.Equals('g')) { return 'ग'; }
            else
            if (strChar.Equals('h')) { return 'ह'; }
            else
            if (strChar.Equals('i')) { return 'ि'; }
            else
            if (strChar.Equals('j')) { return 'ज'; }
            else
            if (strChar.Equals('k')) { return 'क'; }
            else
            if (strChar.Equals('l')) { return 'ल'; }
            else
            if (strChar.Equals('m')) { return 'म'; }
            else
            if (strChar.Equals('n')) { return 'न'; }
            else
            if (strChar.Equals('o')) { return 'े'; }
            else
            if (strChar.Equals('p')) { return 'प'; }
            else
            if (strChar.Equals('q')) { return 'थ'; }
            else
            if (strChar.Equals('r')) { return 'र'; }
            else
            if (strChar.Equals('s')) { return 'स'; }
            else
            if (strChar.Equals('t')) { return 'त'; }
            else
            if (strChar.Equals('u')) { return 'ु'; }
            else
            if (strChar.Equals('v')) { return 'व'; }
            else
            if (strChar.Equals('w')) { return 'ळ'; }
            else
            if (strChar.Equals('x')) { return 'x'; }
            else
            if (strChar.Equals('y')) { return 'य'; }
            else
            if (strChar.Equals('z')) { return 'ठ'; }
            else
            if (strChar.Equals('{')) { return 'उ'; }
            else
            if (strChar.Equals('|')) { return '।'; }
            else
            if (strChar.Equals('}')) { return 'ू'; }
            else
            if (strChar.Equals('╚')) { return 'ङ'; }
            else
            if (strChar.Equals('╔')) { return 'ञ'; }
            else
            if (strChar.Equals('╩')) { return 'ल'; }
            else
            if (strChar.Equals('╦')) { return 'य'; }
            else
            if (strChar.Equals('╠')) { return 'श'; }
            else
            if (strChar.Equals('═')) { return 'ऌ'; }
            else
            if (strChar.Equals('▬')) { return '़'; }
            else
            if (strChar.Equals('▀')) { return '卐'; }
            else
            if (strChar.Equals('α')) { return '\u0951'; }
            else
            if (strChar.Equals('ß')) { return '\u0952'; }
            else
            if (strChar.Equals('Γ')) { return '₹'; }
                return strChar;
        }
    }
}
