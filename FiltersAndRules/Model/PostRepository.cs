using System;
using System.Collections.Generic;
using System.Linq;

namespace FiltersAndRules.Model
{
    public class PostRepository
    {
        public IQueryable<Post> GetAll()
        {
            return new List<Post>() {
       new Post {
           Title = "T4 - The Insource Code Monkey",
           PostedOn = DateTime.Parse("Mon, 03 Jun 2013 00:00:00 GMT"),
           Category = ".Net Tools" ,
           Author = "Nick Harrison",
           Description ="T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.",
           UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/t4---the-insource-code-monkey/",
           ContentEncoded = "<p>T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.</p>",
        IsPublished = true
       },
       new Post {
           Title = "T4 - The Insource Code Monkey",
           PostedOn = DateTime.Parse("Mon, 03 Jun 2013 00:00:00 GMT"),
           Category = ".Net Tools" ,
           Author = "Nick Harrison",
           Description ="T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.",
           UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/t4---the-insource-code-monkey/",
           ContentEncoded = "<p>T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.</p>",
        IsPublished = false
       },
              new Post {
           Title = "T4 - The Insource Code Monkey",
           PostedOn = DateTime.Parse("Mon, 10 Jun 2013 00:00:00 GMT"),
           Category = ".Net Tools" ,
           Author = "Nick Harrison",
           Description ="T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.",
           UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/t4---the-insource-code-monkey/",
           ContentEncoded = "<p>T4 usually stays behind the schenes in Visual Studio,  but if you find that you have a good reason to write similar code over and over again, or  use a lot of copy and paste, then it could be that you have a specific use for T4. There are times when it can be useful for generating code templates but it is versatile to provide a solution for a number of programming headaches.</p>",
        IsPublished = true
       },
       new Post {
        Title = "Modal Input Forms in ASP.NET MVC",
        PostedOn = DateTime.Parse("Wed, 05 Jun 2013 00:00:00 GMT"),
        Category = "ASP.Net",
        Author = "Dino Esposito",
        Description ="Forms in websites have, for a long time, languished in their classic clunky pattern of browser-led 'submit' of content, using the FORM tag. As websites grow nearer to applications in their user-experience, so better is required. Dino show how to get a more sophisticated modal input form based on Twitter Bootstrap, jQuery Validate, and XmlHttpRequest (XHR). ",
        UrlSlug = "https://www.simple-talk.com/dotnet/asp.net/modal-input-forms-in-asp.net-mvc/",
        ContentEncoded = "<p>Forms in websites have, for a long time, languished in their classic clunky pattern of browser-led 'submit' of content, using the FORM tag. As websites grow nearer to applications in their user-experience, so better is required. Dino show how to get a more sophisticated modal input form based on Twitter Bootstrap, jQuery Validate, and XmlHttpRequest (XHR). </p>",
        IsPublished = true
       },
       new Post {
        Title = "Taking NuGet to the Enterprise",
        PostedOn = DateTime.Parse("Wed, 05 Jun 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Alex Papadimoulis",
        Description ="The NuGet package manager  is a great way for developers to install and update third-party tools. It solves a lot of the problems of dependency management and integration. Is it ready for the exacting requirements of  development in the enterprise?",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/taking-nuget-to-the-enterprise/",
        ContentEncoded = "<p>The NuGet package manager  is a great way for developers to install and update third-party tools. It solves a lot of the problems of dependency management and integration. Is it ready for the exacting requirements of  development in the enterprise?</p>",
        IsPublished = false
       },
       new Post {
        Title = "Refactoring CSS with Sass and Compass",
        PostedOn = DateTime.Parse("Mon, 03 Jun 2013 00:00:00 GMT"),
        Category = "ASP.Net",
        Author = "Edward Charbeneau",
        Description ="CSS is still a valuable way of specifying the rendered style of HTML objects. By using a  preprocessor to assist in  generating the CSS, it can make it much simpler to develop and maintain a consistent style  in a web development, despite the increasing complexity of the CSS standard. Sass and Compass, for example, can deliver clean, organized, and efficient CSS code, as Edward demonstrates.",
        UrlSlug = "https://www.simple-talk.com/dotnet/asp.net/refactoring-css-with-sass-and-compass/",
        ContentEncoded = "<p>CSS is still a valuable way of specifying the rendered style of HTML objects. By using a  preprocessor to assist in  generating the CSS, it can make it much simpler to develop and maintain a consistent style  in a web development, despite the increasing complexity of the CSS standard. Sass and Compass, for example, can deliver clean, organized, and efficient CSS code, as Edward demonstrates.</p>",
        IsPublished = true
       },
       new Post {
        Title = "ASP.NET MVC: Annotated for Input",
        PostedOn = DateTime.Parse("Mon, 15 Apr 2013 00:00:00 GMT"),
        Category = "ASP.Net",
        Author = "Dino Esposito",
        Description ="With an ASP.NET MVC application of any size, there comes a time when you are faced with creating utility forms where you don't need a special form layout.  One of the best ways of doing this is by using data annotations. Despite a quirk or two, it can save a lot of time. ",
        UrlSlug = "https://www.simple-talk.com/dotnet/asp.net/asp.net-mvc-annotated-for-input/",
        ContentEncoded = "<p>With an ASP.NET MVC application of any size, there comes a time when you are faced with creating utility forms where you don't need a special form layout.  One of the best ways of doing this is by using data annotations. Despite a quirk or two, it can save a lot of time. </p>",
        IsPublished = true
       },
       new Post {
        Title = "TortoiseSVN and Subversion Cookbook Part 11: Subversion and Oracle",
        PostedOn = DateTime.Parse("Wed, 03 Apr 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Michael Sorens",
        Description ="It is only recently that the tools have existed to make source-control easy for database developers. Although entire build-scripts for databases  could be stored in Subversion, tools like Source Control for Oracle (SoCO) now allow for a more effective  source-control at object-level. ",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/tortoisesvn-and-subversion-cookbook-part-11-subversion-and-oracle/",
        ContentEncoded = "<p>It is only recently that the tools have existed to make source-control easy for database developers. Although entire build-scripts for databases  could be stored in Subversion, tools like Source Control for Oracle (SoCO) now allow for a more effective  source-control at object-level. </p>",
        IsPublished = false
       },
       new Post {
        Title = "Beginning Distributed Version Control with Mercurial",
        PostedOn = DateTime.Parse("Tue, 02 Apr 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Tom Fischer",
        Description ="The move from client-server version ontrol systems (VCS) to distributed version control systems can be bewildering.  Tom uses his experience of moving to Mercurial to explain those aspects of the move that are liable to cause confusion to anyone steeped in the culture of the traditional VCS. Rebase, Push, Pull and Merge explained!",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/beginning-distributed-version-control-with-mercurial/",
        ContentEncoded = "<p>The move from client-server version ontrol systems (VCS) to distributed version control systems can be bewildering.  Tom uses his experience of moving to Mercurial to explain those aspects of the move that are liable to cause confusion to anyone steeped in the culture of the traditional VCS. Rebase, Push, Pull and Merge explained!</p>",
        IsPublished = true
       },
       new Post {
        Title = "Building a Public HTTP API for Data",
        PostedOn = DateTime.Parse("Thu, 21 Mar 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Dino Esposito",
        Description ="The creation of a public API for data presents something of a dilemma for the developer. Web API, with its content negotiation, seems somehow cleverer than classic ASP.NET MVC, but there are complications, such as the XML schema, that suggest that there are merits in using MVC controllers for all public HTTP APIs",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/building-a-public-http-api-for-data/",
        ContentEncoded = "<p>The creation of a public API for data presents something of a dilemma for the developer. Web API, with its content negotiation, seems somehow cleverer than classic ASP.NET MVC, but there are complications, such as the XML schema, that suggest that there are merits in using MVC controllers for all public HTTP APIs</p>",
        IsPublished = true
       },
       new Post {
        Title = "Dynamic LINQ Queries with Expression Trees",
        PostedOn = DateTime.Parse("Mon, 25 Feb 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Nick Harrison",
        Description ="It's possible to build up dynamic LINQ queries or queries with several conditional criteria. In fact there are several options for doing this, including the use of expression trees.",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/dynamic-linq-queries-with-expression-trees/",
        ContentEncoded = "<p>It's possible to build up dynamic LINQ queries or queries with several conditional criteria. In fact there are several options for doing this, including the use of expression trees.</p>",
        IsPublished = true
       },
       new Post {
        Title = "Using SASS and Compass in ASP.Net MVC with Web Workbench",
        PostedOn = DateTime.Parse("Tue, 19 Feb 2013 00:00:00 GMT"),
        Category = "ASP.Net",
        Author = "Edward Charbeneau",
        Description ="The Designers of CSS never envisaged the demands that we make of  styles. However, preprocessors such as SASS can provide the obvious missing features such as constants, selector inheritence and nesting. Compass can in turn use SASS to provide a simple browser-independent way of  expressing complex layout.",
        UrlSlug = "https://www.simple-talk.com/dotnet/asp.net/using-sass-and-compass-in-asp.net-mvc-with-web-workbench/",
        ContentEncoded = "<p>The Designers of CSS never envisaged the demands that we make of  styles. However, preprocessors such as SASS can provide the obvious missing features such as constants, selector inheritence and nesting. Compass can in turn use SASS to provide a simple browser-independent way of  expressing complex layout.</p>",
        IsPublished = true
       },
       new Post {
        Title = "Multiple Views and DisplayMode Providers in ASP.NET MVC 4",
        PostedOn = DateTime.Parse("Mon, 18 Feb 2013 00:00:00 GMT"),
        Category = "ASP.Net",
        Author = "Dino Esposito",
        Description ="Display modes in ASP.NET MVC 4 provide a neat way of separating page content from the way it is rendered on different devices. All you need to do is to define a display mode for each device, or class of devices, that you’re interested in.",
        UrlSlug = "https://www.simple-talk.com/dotnet/asp.net/multiple-views-and-displaymode-providers-in-asp.net-mvc-4/",
        ContentEncoded = "<p>Display modes in ASP.NET MVC 4 provide a neat way of separating page content from the way it is rendered on different devices. All you need to do is to define a display mode for each device, or class of devices, that you’re interested in.</p>",
        IsPublished = false
       },
       new Post {
        Title = "TortoiseSVN and Subversion Cookbook Part 10: Extending the reach of Subversion",
        PostedOn = DateTime.Parse("Tue, 12 Feb 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Michael Sorens",
        Description ="Subversion provides a good way of source-controlling a database, but many operations are best done from within your database-development environmant. Fortunately, several products provide this integration ",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/tortoisesvn-and-subversion-cookbook-part-10-extending-the-reach-of-subversion/",
        ContentEncoded = "<p>Subversion provides a good way of source-controlling a database, but many operations are best done from within your database-development environmant. Fortunately, several products provide this integration </p>",
        IsPublished = true
       },
       new Post {
        Title = "TortoiseSVN and Subversion Cookbook Part 9: Server, Repository, and Statistics",
        PostedOn = DateTime.Parse("Mon, 11 Feb 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Michael Sorens",
        Description ="In the ninth installment of his popular series on using Subversion, Michael describes how to set up a simple Subversion server for a multi-user project and describes some of the reports, charts and tables you can get about the activity in your project ",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/tortoisesvn-and-subversion-cookbook-part-9-server,-repository,-and-statistics/",
        ContentEncoded = "<p>In the ninth installment of his popular series on using Subversion, Michael describes how to set up a simple Subversion server for a multi-user project and describes some of the reports, charts and tables you can get about the activity in your project </p>",
        IsPublished = true
       },
       new Post {
        Title = "Prototyping Desktop Deblector",
        PostedOn = DateTime.Parse("Mon, 28 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Rob Clarke",
        Description ="Deblector is an open-source debugging add-in for .NET Reflector; the Reflector team investigated whether they could integrate it into Reflector's desktop application, and updated the source code to introduce compatibilty with the latest version of Reflector before releasing it back into codeplex",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/prototyping-desktop-deblector/",
        ContentEncoded = "<p>Deblector is an open-source debugging add-in for .NET Reflector; the Reflector team investigated whether they could integrate it into Reflector's desktop application, and updated the source code to introduce compatibilty with the latest version of Reflector before releasing it back into codeplex</p>",
        IsPublished = true
       },
       new Post {
        Title = ".net SmokeTest for Reflector",
        PostedOn = DateTime.Parse("Tue, 22 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Wesley Steiner",
        Description ="With .net SmokeTest, you can take any assembly, construct an instance, call a method, set a property or  field of any class Type from a dialog: Then drill-down into the result without ever writing a single line code. ",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/.net-smoketest-for-reflector/",
        ContentEncoded = "<p>With .net SmokeTest, you can take any assembly, construct an instance, call a method, set a property or  field of any class Type from a dialog: Then drill-down into the result without ever writing a single line code. </p>",
        IsPublished = true
       },
       new Post {
        Title = ".NET Reflector Through the Looking Glass: The Cheese Course",
        PostedOn = DateTime.Parse("Mon, 21 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Michael Sorens",
        Description ="Part 4 describes how you can extend reflector further by describing how reflector can be used to compare or manage assemblies and exercise the code in front of you or even any arbitrary code on the fly.",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/.net-reflector-through-the-looking-glass-the-cheese-course/",
        ContentEncoded = "<p>Part 4 describes how you can extend reflector further by describing how reflector can be used to compare or manage assemblies and exercise the code in front of you or even any arbitrary code on the fly.</p>",
        IsPublished = true
       },
       new Post {
        Title = ".NET Reflector Through the Looking Glass: The Pudding",
        PostedOn = DateTime.Parse("Fri, 18 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Michael Sorens",
        Description ="There a number of ways in which Reflector, either by itself or with  an Addin, allows you to analyse and explore assemblies, or even change the disassembly language",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/.net-reflector-through-the-looking-glass-the-pudding/",
        ContentEncoded = "<p>There a number of ways in which Reflector, either by itself or with  an Addin, allows you to analyse and explore assemblies, or even change the disassembly language</p>",
        IsPublished = false
       },
       new Post {
        Title = ".NET Reflector Through the Looking Glass: The Meat and Potatoes",
        PostedOn = DateTime.Parse("Tue, 15 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Michael Sorens",
        Description =".NET Reflector is most often used for viewing, filtering, navigating, and debugging assemblies to understand it better. Here is how all that is done.",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/.net-reflector-through-the-looking-glass-the-meat-and-potatoes/",
        ContentEncoded = "<p>.NET Reflector is most often used for viewing, filtering, navigating, and debugging assemblies to understand it better. Here is how all that is done.</p>",
        IsPublished = true
       },
      new Post {
        Title = "Windows Store App Contracts ",
        PostedOn = DateTime.Parse("Mon, 14 Jan 2013 00:00:00 GMT"),
        Category = ".Net Framework",
        Author = "Ambily Kavumkal Kamalasanan",
        Description ="Windows Store Apps use contracts to declare the interactions that they support with other apps and with the 'Charm Bar'. They bind your app to other 'Metro' style apps and to the system user-interface: They provide a great deal of functionality for little programming effort.",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-framework/windows-store-app-contracts-/",
        ContentEncoded = "<p>Windows Store Apps use contracts to declare the interactions that they support with other apps and with the 'Charm Bar'. They bind your app to other 'Metro' style apps and to the system user-interface: They provide a great deal of functionality for little programming effort.</p>",
        IsPublished = true
       },
      new Post {
        Title = ".NET Reflector Through the Looking Glass: The Hors d'Oeuvres",
        PostedOn = DateTime.Parse("Mon, 14 Jan 2013 00:00:00 GMT"),
        Category = ".Net Tools",
        Author = "Michael Sorens",
        Description ="Almost everywhere that .NET applications are developed, there is .NET Reflector. Although there have been some blogs on how to use it, there has never been a documentation. Michael Sorens puts the matter right!",
        UrlSlug = "https://www.simple-talk.com/dotnet/.net-tools/.net-reflector-through-the-looking-glass-the-hors-doeuvres/",
        ContentEncoded = "<p>Almost everywhere that .NET applications are developed, there is .NET Reflector. Although there have been some blogs on how to use it, there has never been a documentation. Michael Sorens puts the matter right!</p>",
        IsPublished = false
       }
    }.AsQueryable();
        }
    }
}
