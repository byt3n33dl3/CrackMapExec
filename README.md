# CrackMapExec

<p align="center">
  <img src="https://cloud.githubusercontent.com/assets/5151193/17577511/d312ceb4-5f3b-11e6-8de5-8822246289fd.jpg" alt="cme"/>
</p>

Buffing the **Password Spraying** ability attacks, which involve trying a few common passwords across many accounts to avoid account lockout. Then **User Hunting** attacks method, to identify where specific users are logged in within the network. This is useful for targeting specific high-value *accounts.*

## Kerberos Attack
Upgrading this capabilities for performing Kerberos-based attacks such as AS-REP roasting and Kerberoasting.

```shell
cme kerberos <target> -u <username> -p <password> --asreproast
cme kerberos <target> -u <username> -p <password> --kerberoast
```

## Acknowledgments
**(These are the people who did the hard stuff)**

This project was originally inspired by:
- [CredCrack](https://github.com/gojhonny/CredCrack)
- [smbexec](https://github.com/pentestgeek/smbexec)
- [smbmap](https://github.com/ShawnDEvans/smbmap)

Unintentional contributors:

- The [Empire](https://github.com/PowerShellEmpire/Empire) project
- @T-S-A's [smbspider](https://github.com/T-S-A/smbspider) script
- @ConsciousHacker's partial Python port of Invoke-obfuscation from the [GreatSCT](https://github.com/GreatSCT/GreatSCT) project

You are on the **latest up-to-date** repository of the project CrackMapExec ! 🎉

- If you want to report a problem, open un [Issue](https://github.com/mpgn/CrackMapExec/issues) 
- If you want to contribute, open a [Pull Request](https://github.com/mpgn/CrackMapExec/pulls)
- If you want to discuss, open a [Discussion](https://github.com/mpgn/CrackMapExec/discussions)

## Documentation, Tutorials, Examples
See the project's [wiki](https://www.crackmapexec.wiki/) for documentation and usage examples

## Installation
Please see the installation instructions on the [official wiki](https://www.crackmapexec.wiki/getting-started/installation)

```shell
git clone https://github.com/pxcs/CrackMapExec
cd CrackMapExec
python3 build_collector.py
```