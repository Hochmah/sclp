using Serenity.Navigation;

using MyPages = sc.Default.Pages;

[assembly: NavigationMenu(2000, "Materials", icon: "fa-book")]
[assembly: NavigationLink(2100, "Materials/Materials", typeof(MyPages.MaterialsController), icon: "fa-book")]
[assembly: NavigationLink(2200, "Materials/Material Kind", typeof(MyPages.MaterialKindsController), icon: "glyphicon-th")]
[assembly: NavigationLink(2300, "Materials/Textbooks", typeof(MyPages.TextbooksController), icon: "fa-book")]
[assembly: NavigationLink(2400, "Materials/Textbook Content", typeof(MyPages.TextbookContentController), icon: "fa-file-text")]