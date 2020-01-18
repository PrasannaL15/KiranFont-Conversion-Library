using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF2Uni
{
    
        public class KiranFont
        {
            public String convertKFkiran2Uni(String strIn)
            {
                String strOut;

                //To protect deergh I for Unicode to assume as rafar
                strIn = strIn.Replace("[_", "\u0908");
                strIn = moveRafarLeft(strIn, '_', "r\\");
                strIn = moveikarRight(strIn, 'i', "i");
                strIn = KF2UniPreprocess(strIn);
                strOut = "";

                for (int i = 0; i < strIn.Length; i++)
                {
                    strOut += KFKiran2Uni(strIn.ElementAt(i));
                }

                return KFKiran2UniPostProcess(strOut);
            }


            public String KF2UniPreprocess(String input)
            {
                //Remove spacing character x
                input = input.Replace("x", "");


                //Now take care of jodakshars
                input = input.Replace("&", "ja\\É");
                input = input.Replace("\u00C9", "É\\");
                input = input.Replace("X", "k\\Y");
                input = input.Replace("w", "L\\Y");
                input = input.Replace("F", "f\\Y");
                input = input.Replace("E", "S");
                input = input.Replace("H", "h\\");
                input = input.Replace("`", "\\r");
                input = input.Replace("^", "\\r");
                input = input.Replace("~", "tr\\");
                input = input.Replace("+", "h\\ya");
                input = input.Replace("$", "tt");
                input = input.Replace("%", "r\\\u200D");

                input = input.Replace("\u00d1", "nn");
                input = input.Replace("\u00d2", "d\\ya");
                input = input.Replace("\u00d3", "d\\va");
                input = input.Replace("\u00d4", "d\\Qa");
                input = input.Replace("\u00d5", "d\\d");
                input = input.Replace("\u00d6", "d\\ma");
                input = input.Replace("\u00d7", "T\\T");
                input = input.Replace("\u00d8", "T\\z");
                input = input.Replace("\u00d9", "D\\D");
                input = input.Replace("\u00da", "D\\Z");
                input = input.Replace("\u00db", "z\\z");
                input = input.Replace("\u00dc", "h\\r");
                input = input.Replace("\u00dd", "h\\ma");

                //Protect all half characters by adding halant

                input = input.Replace("B", "B\\");
                input = input.Replace("E", "E\\");
                input = input.Replace("G", "G\\");
                input = input.Replace("J", "J\\");
                input = input.Replace("K", "K\\");
                input = input.Replace("N", "N\\");
                input = input.Replace("Q", "Q\\");
                input = input.Replace("S", "S\\");
                input = input.Replace("X", "X\\");
                input = input.Replace("Y", "Y\\");
                input = input.Replace("b", "b\\");
                input = input.Replace("c", "c\\");
                input = input.Replace("g", "g\\");
                input = input.Replace("j", "j\\");
                input = input.Replace("l", "l\\");
                input = input.Replace("m", "m\\");
                input = input.Replace("n", "n\\");
                input = input.Replace("p", "p\\");
                input = input.Replace("q", "q\\");
                input = input.Replace("s", "s\\");
                input = input.Replace("t", "t\\");
                input = input.Replace("v", "v\\");
                input = input.Replace("y", "y\\");
                input = input.Replace("~/", "~\\");


                //now nullify halant and kana
                input = input.Replace("\\a", "");


                return input;
            }
            public Char KFKiran2Uni(Char strChar)
            {
                  Convert.ToChar(10);
            /*
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
                 if (strChar.Equals('E')) { return 'ड'; }
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
                 if (strChar.Equals('U')) { return 'ू'; }
                 else
                 if (strChar.Equals('V')) { return 'ॅ'; }
                 else
                 if (strChar.Equals('Y')) { return 'ष'; }
                 else
                 if (strChar.Equals('Z')) { return 'ढ'; }
                 else
                 if (strChar.Equals('[')) { return 'इ'; }
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
                 if (strChar.Equals('Γ')) { return '₹'; }*/
  if (strChar.Equals(Convert.ToChar(35))) return Convert.ToChar(2365);
  if (strChar.Equals(Convert.ToChar(42))) return Convert.ToChar(2384);
  if (strChar.Equals(Convert.ToChar(48))) return Convert.ToChar(2406);
  if (strChar.Equals(Convert.ToChar(49))) return Convert.ToChar(2407);
  if (strChar.Equals(Convert.ToChar(50))) return Convert.ToChar(2408);
  if (strChar.Equals(Convert.ToChar(51))) return Convert.ToChar(2409);
  if (strChar.Equals(Convert.ToChar(52))) return Convert.ToChar(2410);
  if (strChar.Equals(Convert.ToChar(53))) return Convert.ToChar(2411);
  if (strChar.Equals(Convert.ToChar(54))) return Convert.ToChar(2412);
  if (strChar.Equals(Convert.ToChar(55))) return Convert.ToChar(2413);
  if (strChar.Equals(Convert.ToChar(56))) return Convert.ToChar(2414);
  if (strChar.Equals(Convert.ToChar(57))) return Convert.ToChar(2415);
  if (strChar.Equals(Convert.ToChar(65))) return Convert.ToChar(2309);
  if (strChar.Equals(Convert.ToChar(66))) return Convert.ToChar(2349);
  if (strChar.Equals(Convert.ToChar(67))) return Convert.ToChar(2331);
  if (strChar.Equals(Convert.ToChar(68))) return Convert.ToChar(2337);
  if (strChar.Equals(Convert.ToChar(71))) return Convert.ToChar(2328);
  if (strChar.Equals(Convert.ToChar(73))) return Convert.ToChar(2368);
  if (strChar.Equals(Convert.ToChar(74))) return Convert.ToChar(2333);
  if (strChar.Equals(Convert.ToChar(75))) return Convert.ToChar(2326);
  if (strChar.Equals(Convert.ToChar(76))) return Convert.ToChar(2355);
  if (strChar.Equals(Convert.ToChar(77))) return Convert.ToChar(2306);
  if (strChar.Equals(Convert.ToChar(78))) return Convert.ToChar(2339);
  if (strChar.Equals(Convert.ToChar(79))) return Convert.ToChar(2376);
  if (strChar.Equals(Convert.ToChar(80))) return Convert.ToChar(2315);
  if (strChar.Equals(Convert.ToChar(81))) return Convert.ToChar(2343);
  if (strChar.Equals(Convert.ToChar(82))) return Convert.ToChar(2371);
  if (strChar.Equals(Convert.ToChar(83))) return Convert.ToChar(2358);
  if (strChar.Equals(Convert.ToChar(84))) return Convert.ToChar(2335);
  if (strChar.Equals(Convert.ToChar(85))) return Convert.ToChar(2370);
  if (strChar.Equals(Convert.ToChar(86))) return Convert.ToChar(2373);
  if (strChar.Equals(Convert.ToChar(89))) return Convert.ToChar(2359);
  if (strChar.Equals(Convert.ToChar(90))) return Convert.ToChar(2338);
  if (strChar.Equals(Convert.ToChar(91))) return Convert.ToChar(2311);
  if (strChar.Equals(Convert.ToChar(92))) return Convert.ToChar(2381);
  if (strChar.Equals(Convert.ToChar(93))) return Convert.ToChar(2369);
  if (strChar.Equals(Convert.ToChar(97))) return Convert.ToChar(2366);
  if (strChar.Equals(Convert.ToChar(98))) return Convert.ToChar(2348);
  if (strChar.Equals(Convert.ToChar(99))) return Convert.ToChar(2330);
  if (strChar.Equals(Convert.ToChar(100))) return Convert.ToChar(2342);
  if (strChar.Equals(Convert.ToChar(101))) return Convert.ToChar(2319);
  if (strChar.Equals(Convert.ToChar(102))) return Convert.ToChar(2347);
  if (strChar.Equals(Convert.ToChar(103))) return Convert.ToChar(2327);
  if (strChar.Equals(Convert.ToChar(104))) return Convert.ToChar(2361);
  if (strChar.Equals(Convert.ToChar(105))) return Convert.ToChar(2367);
  if (strChar.Equals(Convert.ToChar(106))) return Convert.ToChar(2332);
  if (strChar.Equals(Convert.ToChar(107))) return Convert.ToChar(2325);
  if (strChar.Equals(Convert.ToChar(108))) return Convert.ToChar(2354);
  if (strChar.Equals(Convert.ToChar(109))) return Convert.ToChar(2350);
  if (strChar.Equals(Convert.ToChar(110))) return Convert.ToChar(2344);
  if (strChar.Equals(Convert.ToChar(111))) return Convert.ToChar(2375);
  if (strChar.Equals(Convert.ToChar(112))) return Convert.ToChar(2346);
  if (strChar.Equals(Convert.ToChar(113))) return Convert.ToChar(2341);
  if (strChar.Equals(Convert.ToChar(114))) return Convert.ToChar(2352);
  if (strChar.Equals(Convert.ToChar(115))) return Convert.ToChar(2360);
  if (strChar.Equals(Convert.ToChar(116))) return Convert.ToChar(2340);
  if (strChar.Equals(Convert.ToChar(117))) return Convert.ToChar(2369);
  if (strChar.Equals(Convert.ToChar(118))) return Convert.ToChar(2357);
  if (strChar.Equals(Convert.ToChar(119))) return Convert.ToChar(2355);
  if (strChar.Equals(Convert.ToChar(121))) return Convert.ToChar(2351);
  if (strChar.Equals(Convert.ToChar(122))) return Convert.ToChar(2336);
  if (strChar.Equals(Convert.ToChar(123))) return Convert.ToChar(2313);
  if (strChar.Equals(Convert.ToChar(124))) return Convert.ToChar(2404);
  if (strChar.Equals(Convert.ToChar(125))) return Convert.ToChar(2370);
  if (strChar.Equals(Convert.ToChar(200))) return Convert.ToChar(2329);
  if (strChar.Equals(Convert.ToChar(201))) return Convert.ToChar(2334);
  if (strChar.Equals(Convert.ToChar(202))) return Convert.ToChar(2354);
  if (strChar.Equals(Convert.ToChar(203))) return Convert.ToChar(2351);
  if (strChar.Equals(Convert.ToChar(204))) return Convert.ToChar(2358);
  if (strChar.Equals(Convert.ToChar(205))) return Convert.ToChar(2316);
  if (strChar.Equals(Convert.ToChar(222))) return Convert.ToChar(2364);
  if (strChar.Equals(Convert.ToChar(223))) return '卐';
  if (strChar.Equals(Convert.ToChar(224))) return Convert.ToChar(2385);
  if (strChar.Equals(Convert.ToChar(225))) return Convert.ToChar(2386);
  if (strChar.Equals(Convert.ToChar(226))) return Convert.ToChar(8377);


                return strChar;
            }

            public String KFKiran2UniPostProcess(String strOut)
            {
                strOut = strOut.Replace("\u093e\u0947", "\u094B"); // a + o
                strOut = strOut.Replace("\u093e\u0948", "\u094C"); // a + O
                strOut = strOut.Replace("\u0905\u093e", "आ"); // A + a
                strOut = strOut.Replace("\u0905\u094b", "ओ"); // A + ao
                strOut = strOut.Replace("\u0905\u094c", "औ"); // A + aO

                strOut = strOut.Replace("\u090f\u0947", "ऐ"); // e + o
                strOut = strOut.Replace("\u0945\u0902", "\u0901"); // V + M
                strOut = strOut.Replace("\u093e\u0945", "\u0949"); // a + V
                strOut = strOut.Replace("\u093e\u0945", "\u0949"); // a + V
                                                                   //Added: 11 MAY 2018
                strOut = strOut.Replace("\u0906\u0945", "ऑ"); // Aa + V
                strOut = strOut.Replace("\u0909\u0941", "ऊ"); // u + u


                return strOut;
            }
        String moveikarRight(String strIn,char strFind,String strReplace)
        {
            String strVowelSigns = "aiIeoOuU]}`^Vx_";//Vowel String (Characters to be skipped after consonant cluster before putting the Rafar
            String strPunctuations = ". ?/!@:\u0009";//Non-Vowel non character string
            String strSingleLetterChars = "CTzDZdrhL\u00c8"; //Single character full letters 200 ng
            String strHalfChars =
            "$%&BEFGHJKNQSWXYbcgjlmnpqstvwy~\u00c9\u00cc"; // last 3 chars 126 tr, 201 nj, 204 sh

            String[] arr = strIn.Split(strFind);

            if (arr.Length == 0) return strIn; //Just in case

            String  strOut = arr[0];
            int j;
            // [ ][ ][ ][ ][ ][ ][ ][ ][ ]
            //  ^  -->
            //check from beginning of each string for any character in string s and put rafar after that or sequence of those consonant clusters.
                    for (int i = 1;  i < arr.Length; i++) //We need to process 2nd part onwards
                    {   j = 0;
                        for ( j = 0; j < arr[i].Length; j++)
                        {
                            if ((strSingleLetterChars + strHalfChars + "kf").IndexOf( arr[i].ElementAt(j) ) == -1)
                            {
                                // If the character is not one of these, break, put on the rafar here itself as it may indicate error.
                                break;
                            } // Means we have got a valid consonant to start with
                            else
                            {
                                while (j < arr[i].Length)
                                {
                                    if (strHalfChars.IndexOf(arr[i].ElementAt(j)) != -1)
                                    {
                                        //					alert( "1a Half Consonant scan: \n i=" + i + " j=" + j + " \n String=" + arr[i] );
                                        j++;
                                    }
                                    else if (strSingleLetterChars.IndexOf(arr[i].ElementAt(j)) != -1)
                                    {
                                        //					alert( "1b Full Letter Consonant scan: \n i=" + i + " j=" + j + " \n String=" + arr[i] );
                                        j++; //Pass the single letter character;
                                        if (j < arr[i].Length)
                                        {
                                            if (arr[i].ElementAt(j) == '\\')
                                            {
                                                j++;//This one is also half character!! So continue
                                            }
                                            else break;
                                        }
                                    } // Means it is not half character and not single letter character followed by \ to make it half, stop here.
                                    else
                                    {
                                        //					alert( "1c Full Letter Consonant scan: \n i=" + i + " j=" + j + " \n String=" + arr[i] );
                                        j++;
                                        break;
                                    }
                                }

                                // Here We should be at the end of the consonant cluster
                                //					alert( "Consonant scan: \n i=" + i + " j=" + j + " \n String=" + arr[i] );
                                if (j < arr[i].Length)
                                {
                                    while (strVowelSigns.IndexOf(arr[i].ElementAt(j)) != -1 )
                                        if(j < arr[i].Length-1)
                                        {       j++; 
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    //parse through vowel cluster
                                }   //					alert( "Vowel scan: \n i=" + i + " j=" + j + " \n String="  + arr[i] + " found location:" + j + arr[i].substring(0, j) + " ~~~ " + arr[i].substring(j));
                                break;
                            }
                        }
                        strOut = strOut + arr[i].Substring(0, j) + strReplace + arr[i].Substring(j);
            //			alert ("Array String added: \n i=" + i + " j=" + j + " \n Original="+ arr[i] +" \nString=" + arr[i].substring(0, j) + "_" + arr[i].substring(j));
                    }

            return strOut;
        }
        String moveRafarLeft(String strIn, char strFind, String strReplace)
            {
                int unicode = 9;
                char character = (char)unicode;
                string fromcharcode9 = character.ToString();
                String strVowelSigns = "aiIeoOuU]}`^Vx_";//Vowel String (Characters to be skipped after consonant cluster before putting the Rafar
                String strPunctuations = ". ?/!@:" + fromcharcode9; //Non-Vowel non character string
                String strSingleLetterChars = "CTzDZdrhLÈ"; //Single character full letters 200 ng     
                String strHalfChars = "$%&BEFGHJKNQSWXYbcgjlmnpqstvwy~ÉÌ";// last 3 chars 126 tr, 201 nj, 204 sh
                String[] arr = strIn.Split(strFind);
                int j;
                if (arr.Length <= 0) return strIn;
                String strOut;
                strOut = arr[arr.Length - 1];

                for (int i = arr.Length - 2; i >= 0; i--)
                {
                    for (j = arr[i].Length - 1; j >= 0; j--)
                    {
                        while (strVowelSigns.IndexOf(arr[i].ElementAt(j)) != -1 && j >= 0)
                        {
                            j--;
                        }
                        if (strSingleLetterChars.IndexOf(arr[i].ElementAt(j)) != -1 && j >= 0)
                        {
                            j--;
                           
                            if(j>=0)
                            while (arr[i].ElementAt(j).Equals('\\') && j >= 0)
                            {
                                
                                j--;
                                j--;
                                if (j < 0) break;
                            }
                            if(j>=0)
                            while (strHalfChars.IndexOf(arr[i].ElementAt(j)) != -1 && j >= 0)
                            {
                                j--;
                            }
                            break;
                        }

                        while (strHalfChars.IndexOf(arr[i].ElementAt(j)) != -1 && j >= 0)
                        {
                        
                            j--;
                           if(j<0)
                            {
                            break;
                            }
                        }
                        break;
                    }
                    strOut = arr[i].Substring(0, j + 1) + strReplace + arr[i].Substring(j + 1) + strOut;

                }


                return strOut;
            }
        }
    
}
