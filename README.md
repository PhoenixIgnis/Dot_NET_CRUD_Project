<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project">
    <img src="https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project/blob/master/Images/logo_NETcore.svg" alt="Logo" width="160" height="160">
  </a>

  <h3 align="center">.NET CRUD</h3>

  <p align="center">
    A .NET CRUD made as an excercise!
    <br />
    <a href="https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project"><strong>Explore the docs //TODO»</strong></a>
    <br />
    <br />
    <a href="https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project">View Demo //TODO</a>
  </p>
</div>

<br />
<br />
    
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation-instructions">Installation Instructions</a></li>
      </ul>
    </li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This is a C# CRUD (Create, Read, Update, Delete) project built using the following technologies:

* C# for the main programming language
* Entity Framework Core for data access and management
* Razor Pages for building the web interface
* SQL Server for storing the data
* ClosedXML for exporting data to Excel
* Bootstrap for styling and layout

The project is designed as an exercise for an interview for a developer position. It is a simple web application that allow CRUD operations on a database of Buildings, Customers and PartNumbers tables. Additionally, the project has implemented functionality to export data to excel using ClosedXML library. The user interface is built using Razor Pages and Bootstrap for a responsive and user-friendly experience. The goal of this project is to showcase the developer's (Me) skills in using the above technologies.

The database:
<div align="center">
  <img src="https://github.com/PhoenixIgnis/JABIL-Project/blob/master/Design/DBDiagram.png" alt="Database Diagram">
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

* ![BootStrap][Bootstrap.com]
* ![ClosedXML][ClosedXML]
* ![Entity Framework Core][EFCore]
* ![Razor Pages][RazorPages]



<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started
To get a local copy up and running follow these simple steps.

### Prerequisites

* Visual Studio 2022
  ```sh
  Download and Install https://visualstudio.microsoft.com/vs/
  ```
* ASP.NET Core Runtime version 7.02
* ```sh
  Download and Install https://dotnet.microsoft.com/en-us/download/dotnet/7.0
  ```
 
* SQLServer 18>
* ```sh
  Download and Install https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms
  ```

### Installation Instructions

1. Clone the repo
   ```sh
   git clone https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project.git
   ```
2. Install Packages via NuGet
   ```sh
   install-Package ClosedXML
   ```
   ```sh
   install-Package Microsoft.EntityFrameworkCore.SqlServer 
   ```
   ```sh
   install-Package Microsoft.EntityFrameworkCore.Tools      
   ```
3. Create the local SQLServer Database
   ```sh
   Update-Database
   ```
4. Initialize The Database
   ```sh
   Run the program and data will be seeded automatically.
   ```
5. Run the project in Visual Studio
  

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the Mozilla Public License 2.0. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Isaac Rodriguez - IE.RG@Outlook.com

Project Link: [.NET CRUD Project](https://github.com/PhoenixIgnis/Dot_NET_CRUD_Project)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Best-README-Template](https://github.com/othneildrew/Best-README-Template)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com/
[EFCore]: https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=.NET&logoColor=white
[ClosedXML]: https://img.shields.io/badge/-ClosedXML-40bf00?style=for-the-badge&logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAMAAAAPdrEwAAAB+1BMVEUAAADh8eHh8uHg8OHf8OBBpEVCpEZCpUZDpUdFqElGpkpGqUpHpktHqUpHqUtHqktIpktIpkxIqUxJpkxJpk1JqE1Kpk1Kpk5Kp05Kqk1Lp05Mr1BNr1BNr1FOp1FOsFJPqFNPq1NQqFNQqFRQsVNQsVRRqFRRqFVRrFVRsVVSqVVSqVZSslVTqVZTrVdUr1dVrllWqllXqllXsVpYqltYq1tZq1tZq1xatV5ctmBdt2Bft2NhuGVitGViuWVkumdmu2lntmpovGtpvG1qvG5ruG1rvW5tuXBtvnBuunFuvnFuvnJvu3Jvv3JywHV6u3x6w316xH18xX99xYB+vIB/wYGDxIaDyIaIyouMxI6NxI+Z0puf1KGgyKGg1KKhyKKhyaKhzKKi1aSj1qWkzaWk16an1amo2Kqp2Kup2auq2ayr0ayr162s166t0q6u26+y3LSy3bS13ra23ri317i337i417i417m437q517m52Lm52Lq54Lq737y837284b6+27+/27+/28C/4cHA48HB3cLB4sPC3cLC3cPR6tLR69LS69PU5dTU5dXV5dXV5dbV5tbV7NbW5tbW7NfX7djY59ja7tvb6dvb6dzc6dzd6t7d8N3d8N7e6t7e697j7uPj7uTk7uT8/fz8/vz8/v39/v3+//7+//////+Gpmy5AAAABXRSTlMAqqrB1/4Ehh4AAAMpSURBVHjatNaDdiBLEMbxvqjYTjqXa9u2bWdt2/ZubDvzmDvB8DupntSZ/B/gN2gqr6+n962YqLW8SSv3n6tS2J01OpbWPwzB39fq2Npc65ev/aNjbNJdTz6hY+6iI1/VcffXPTXUt3907E2rH6LX6nFoh7K7o8el1zYtnM/H/9Js25X6KpMf9H802K3qpFC2LIN9Re2VyI9s2bZLNdMRtUIq233m3nujmiiXeXu5Espme+nY6ce2jLacRhltMQ2y04WYaJQrCzJ4WixX5xGhjbRAziVCG2mBnE1DpfO0XEabp1G2QM4ip4W3/pLTj1BOc+VFHdaXv3haLltgIy2UwWZpXs4KyWAzNCtXZrvyYltGOyKd02SW0Y5CJ9P/IbsiF2SwedqRKWSX56EMNk87csguL0DZrecgR4Ps2CAvArmvjFIj0sVEIbu8iJfJsQ304+bJIdss2zbSKFtWW9AuLzHLto00ykG78adZdmygQbbtKeT0d5FZdmygQbZrnk5OnHyGyG8jjTLavOzYo9JPLTe0F3Oy0xw1itxvBexZRhn6T3Gyz/6f3ObxMk8/C8vWz0Jym9DIyxz9HOUiIrRRRtooF1Cg/xsZmaFRLvfJYPegjDTKsPOj3Q0y0IycS07zZ/ltXgaalZd0NHv2v42DchlFpZ8PgOw7uzstK2AzMtDPLZCz/LJdm8+uAxloRvbdvmw5ZCcQT/Ny8J2Hap+BjIE+1g9yijeCtuza08dK63e8zNscDXZ5Gsq8jTTaKIdqSIpMo12excjMGgQa7J/ZvCygS99FkE9RZBrsn7mM3MPILK3/emf9yJPJQIN91id3heVeTgYayhxd7uNlpNGWy0ijLZaBBlsqAw22WAYaui6XTfRfb+Uy0mjLZKCh0jf8GjTSk6LY3WYZmq1Wa6Y3cplWqQOat6UyHVLnNW9LZbqkarTBFsoJfyq1wWDvIVGblFIvtKFMEf1e2W0dD3uLGqx+Wvx2/p9qqPs6bjvxpRrp8l/x2ok3lduTmXHa+a+Ur5bd8dk7/1DBfq3Fjypms3m2MWACpvwIX2tL3MBYgwAwcAzLYUSYBwBsLOERTSjfUAAAAABJRU5ErkJggg==
[RazorPages]: https://img.shields.io/badge/Razor%20Pages-512BD4?style=for-the-badge&logo=.NET&logoColor=white


