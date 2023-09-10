<a name="readme-top"></a>



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://codewithmosh.com/">
    <img src="https://github.com/lorenarms/PanIQ_HintDB/blob/master/PanIQ%20HintDB/wwwroot/Images/horseshoe.png" alt="Logo">
  </a>

  <h3 align="center">Escape Room Hint Databse</h3>

  <p align="center">
    A web application built from scratch with C# and ASP.NET Core
    <br />
    <a href="https://github.com/lorenarms/PanIQ_HintDB/tree/master"><strong>Explore the files »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/eOAyYExhRh4">View the demo</a>
    ·
    <a href="https://www.youtube.com/watch?v=ltE63Xm3bh4&list=PLhz6FAyiBzY6kAOeiksSwaB5887EGQIyY">See more projects</a>
    
  </p>
</div>



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
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
<p>
<img src="https://github.com/lorenarms/PanIQ_HintDB/blob/master/PanIQ%20HintDB/wwwroot/Images/short%20demo.gif">
<p/>
  
_Adding a hint to the database, showcasing dynamic dropdown menus_

<p>
I designed and built this project from scratch with the goal of creating an easy-to-use web application for escape room Game Masters to log hints.
</p>

### The Goal

My goal for this project was to build an easy-to-use web-application for game masters to track hints and problems (glitches) in the escape room, during the normal course of gameplay. The application needed to have access to a databse of the entries for technicians and managers to review and query. 

<p>
  During the course of a typical escape room game, players need hints to help them move forward with certain puzzles. Until now, those hints were logged in a Google spreadsheet, with a new document for each week. This resulted in a large amount of data that was ultimately hard to manage and search.
</p>

<img src="https://github.com/lorenarms/PanIQ_HintDB/blob/master/PanIQ%20HintDB/wwwroot/Images/log_page.png">

_Hint Log database using DataTables_

<p>
  This application addresses that issue by keeping all hint logs in one database that is easily managed and searched. The Form prepopulates the date and time so Game Masters don't have to worry about doing that themselves. The Form is dynamic, and the dropdown selections change based on the previous drop down option that is seleced by the Game Master.
</p>

### Why did I build this?

<p>
I found the old "database" system was cumbersome for Game Masters during games, especially when they are managing three or more at once. This was also a good way for me to practice my API-building skills using SQL databases. I love to practice the new things I learn and this was a great way for me to do that. 
</p>
<p>
Just like all my other projects, there were minor issues and bugs to work through, and that was also a great way for me to challenge myself and flex my "troubleshooting" muscle. There are still some features that I would like to implement, but as of right now the application is out of beta and serving its purpose. 


</p>
<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

This project was built with the following applications, languages, and libraries. Additionally, the project makes use of <a href="https://bootboxjs.com/">Bootbox.js</a> for custom dialogs, and <a href="https://datatables.net/">Datatables</a> for easy-to-use database display.

[![VS][Visual Studio]][vs-url]
[![dotnet][dotnet]][net-url]
[![csharp][csharp]][csharp-url]
[![Bootstrap][Bootstrap.com]][Bootstrap-url]
[![JQuery][JQuery.com]][JQuery-url]

[Visual Studio]: https://img.shields.io/badge/visual_studio_2022-ffffff?style=for-the-badge&logo=visualstudio&logoColor=purple
[vs-url]: https://visualstudio.microsoft.com/vs/
[dotnet]: https://img.shields.io/badge/Microsoft_.net-ffffff?style=for-the-badge&logo=dotnet&logoColor=purple
[net-url]: https://visualstudio.microsoft.com/vs/](https://dotnet.microsoft.com/en-us/
[csharp]: https://img.shields.io/badge/C_Sharp-590ec4?style=for-the-badge&logo=csharp&logoColor=white
[csharp-url]: https://dotnet.microsoft.com/en-us/languages/csharp

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

Feel free to fork the poject as needed.

### Prerequisites

You'll want to start with <a href="https://visualstudio.microsoft.com/">Visual Studio</a>

### Installation

_Installing the various extensions can be done via the VS Package Manager Console, or by right-clicking the project and selecting "Add > Client-Side Library"_

I will provide a video in the near future showing how to do this.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- OTHER ITEMS -->

<!-- ROADMAP -->
## Roadmap

- [x] "Add Puzzle" Feature
- [ ] "Add Hint" Feature
- [ ] Change syling to better match business logo

See the [open issues](https://github.com/lorenarms/PanIQ_HintDB/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Currently there is no license for this application, it is free to use by anyone who needs it. Please consider letting me know if it was helpful at all, or any additions you can propose (see the <a href="#contributing">contributing</a> section)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

<p>Check out my <a href="https://www.youtube.com/channel/UCGtp8PRHgPCQHYoSxbMST8A" target="_blank">YouTube channel</a> for more videos about coding projects I've done.</p>
<p>Also, check out my <a href="http://artllj.com" target="_blank">Personal Website</a> for more information about me, and my <a href="https://www.linkedin.com/in/lorenarms95/" target="_blank">LinkedIn</a> to see if I'd be a good fit for your team. </p>
<h3>Thanks for stopping by!</h3>
<img src="https://github.com/lorenarms/SNHU_CS_370_Emerging_Trends_in_CS/blob/main/images/profile.png" alt="[picture of me]" style="width:100px;">
<p>much love
-L
</p>

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Best README Template](https://github.com/lorenarms/README-Template)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/lorenarms/PanIQ_HintDB.svg?style=for-the-badge
[contributors-url]: https://github.com/lorenarms/PanIQ_HintDB/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/lorenarms/PanIQ_HintDB.svg?style=for-the-badge
[forks-url]: https://github.com/lorenarms/PanIQ_HintDB/forks
[stars-shield]: https://img.shields.io/github/stars/lorenarms/PanIQ_HintDB.svg?style=for-the-badge
[stars-url]: https://github.com/lorenarms/PanIQ_HintDB/stargazers
[issues-shield]: https://img.shields.io/github/issues/lorenarms/PanIQ_HintDB.svg?style=for-the-badge
[issues-url]: https://github.com/lorenarms/PanIQ_HintDB/issues
[license-shield]: https://img.shields.io/github/license/lorenarms/PanIQ_HintDB.svg?style=for-the-badge
[license-url]: https://github.com/lorenarms/PanIQ_HintDB/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&color=blue
[linkedin-url]: https://linkedin.com/in/lorenarms95


[product-screenshot]: https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movies%20index.png


[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
