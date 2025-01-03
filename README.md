# CrackMapExec

<p align="center">
  <img src="https://cloud.githubusercontent.com/assets/5151193/17577511/d312ceb4-5f3b-11e6-8de5-8822246289fd.jpg" alt="cme"/>
</p>

## Continuing the `CrackMapExec` Project

[![License: BSD 3-Clause](https://img.shields.io/badge/License-BSDv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

Buffing the **Password Spraying** ability attacks, which involve trying a few common `passwords` across many accounts to avoid account lockout. Then **User Hunting** attacks method, to identify where specific users are logged in within the network. This is useful for targeting specific high-value *accounts.*

## Kerberos Attacks
Upgrading this capabilities for performing Kerberos-based attacks such as AS-REP roasting and Kerberoasting.

```shell
cme kerberos <target> -u <username> -p <password> --asreproast
cme kerberos <target> -u <username> -p <password> --kerberoast
```

## Acknowledgments
**( These are the people who did the hard stuff )**

This project was originally inspired by:
- [CredCrack](https://github.com/gojhonny/CredCrack)
- [smbexec](https://github.com/pentestgeek/smbexec)
- [smbmap](https://github.com/ShawnDEvans/smbmap)

Unintentional contributors:

- The [Empire](https://github.com/PowerShellEmpire/Empire) project
- @T-S-A's [smbspider](https://github.com/T-S-A/smbspider) script
- @ConsciousHacker's partial Python port of Invoke-obfuscation from the [GreatSCT](https://github.com/GreatSCT/GreatSCT) project

You are on the **latest up-to-date** CrackMapExec

- If you want to report a problem, open un [Issue](https://github.com/byt3n33dl3/CrackMapExec/issues) 
- If you want to contribute, open a [Pull Request](https://github.com/byt3n33dl3/CrackMapExec/pulls)
- If you want to discuss, open a [Discussion](https://github.com/byt3n33dl3/CrackMapExec/discussions)

## Documentation, Tutorials, Examples
See the project's [wiki](https://www.crackmapexec.wiki/) for documentation and usage examples

## Thanks to
- Marcello
- cube0x0 ( for SME )
- GhostPack ( Rubeus )

## Installation
Please see the installation instructions on the [official wiki](https://www.crackmapexec.wiki/getting-started/installation)

```shell
git clone https://github.com/byt3n33dl3/CrackMapExec
cd CrackMapExec
python3 crackmapexec
```

## Code Contributors

Awesome code contributors of CrackMapExec

[![](https://github.com/byt3n33dl3.png?size=50)](https://github.com/byt3n33dl3)
[![](https://github.com/Marshall-Hallenbeck.png?size=50)](https://github.com/Marshall-Hallenbeck)
[![](https://github.com/zblurx.png?size=50)](https://github.com/zblurx)
[![](https://github.com/NeffIsBack.png?size=50)](https://github.com/NeffIsBack)
[![](https://github.com/Hackndo.png?size=50)](https://github.com/Hackndo)
[![](https://github.com/Projectdiscovery.png?size=50)](https://github.com/Projectdiscovery)
