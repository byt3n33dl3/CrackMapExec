﻿using System;
using System.Collections.Generic;
using System.IO;
using static SharpMapExec.Helpers.SecurityContext;

namespace SharpMapExec.Commands
{
    public class NtlmSmb : ICommand
    {
        public static string CommandName => "ntlmsmb";

        public void Execute(Dictionary<string, string> arguments)
        {
            string[] user;
            string domain = "";
            string path = "";
            string destination = "";
            string[] computernames;
            string[] hashes = null;
            string[] passwords = null;
            string module = "";
            string moduleargument = "";
            List<string> flags = new List<string>();

            if (arguments.ContainsKey("/m"))
            {
                module = arguments["/m"];
            }
            if (arguments.ContainsKey("/module"))
            {
                module = arguments["/module"];
            }
            if (arguments.ContainsKey("/a"))
            {
                moduleargument = arguments["/a"];
            }
            if (arguments.ContainsKey("/argument"))
            {
                moduleargument = arguments["/argument"];
            }


            //
            if (arguments.ContainsKey("/domain"))
            {
                domain = arguments["/domain"];
            }
            else
            {
                domain = ".";
            }

            if (arguments.ContainsKey("/user"))
            {
                if (File.Exists(arguments["/user"]))
                {
                    user = File.ReadAllLines(arguments["/user"]);
                }
                else
                {
                    string[] parts = arguments["/user"].Split('\\');
                    if (parts.Length == 2)
                    {
                        domain = parts[0];
                        user = parts[1].Split(',');
                    }
                    else
                    {
                        user = arguments["/user"].Split(',');
                    }
                }
            }
            else
            {
                Console.WriteLine("[-] /user must be supplied!");
                return;
            }

            if (arguments.ContainsKey("/computername"))
            {
                if (File.Exists(arguments["/computername"]))
                {
                    computernames = File.ReadAllLines(arguments["/computername"]);
                }
                else
                {
                    computernames = arguments["/computername"].Split(',');
                }
            }
            else
            {
                Console.WriteLine("[-] /computername must be supplied!");
                return;
            }

            if (arguments.ContainsKey("/password"))
            {
                if (File.Exists(arguments["/password"]))
                {
                    passwords = File.ReadAllLines(arguments["/password"]);
                }
                else
                {
                    passwords = arguments["/password"].Split(',');
                }
            }
            else if (arguments.ContainsKey("/ntlm"))
            {
                if (File.Exists(arguments["/ntlm"]))
                {
                    hashes = File.ReadAllLines(arguments["/ntlm"]);
                }
                else
                {
                    hashes = arguments["/ntlm"].Split(',');
                }
            }
            else
            {
                Console.WriteLine("[-] /password or /ntlm must be supplied");
                return;
            }
            Lib.ntlm.Ntlm(user, domain, passwords, hashes, computernames, "", module, moduleargument, path, destination, flags, "smb");
        }
    }
}