## MiJenner.MauiMvvm 
This is a template for my high school students for doing .NET MAUI apps with a MVVMS architecture. Idea is that they use it for
(a) learning the structure of MVVM architecture, (b) learn how to set up "things" in .NET MAUI, (c) use it as a basis for their own applications. 

# Features 
It has folders for the MVVMS architecture, i.e. Models, Views, ViewModels and Services. 

It has a simple example model, Item. MainViewModel create an observable list of Item's and display it in a CollectionView. 

It has three views: MainPage, DetailsPage, and ConfigPage. 

Navigation is operational. Navigation to ConfigPage is simple, without passing data. Navigation to DetailsPage passes an instance of Item to DetailsPage. 

It has a view-model per page which often seems to be useful. In addition it has a BaseViewModel for common stuff like Title, IsBusy and much more. This is highly inspired by Mr James Montemagno and the MonkeyFinder-project. 

# Package dependencies 
It uses Nuget packages: CommunityToolkit.Mvvm (https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/) and CommunityToolkit.Maui (https://github.com/CommunityToolkit/Maui) enabling less boilerplate code to be written. 

It uses MiJenner.ServicesMAUI Nuget package, source code here: https://github.com/mijenner/MiJenner.ServicesMAUI for easy file-system access 
and storage of user settings. This is highly inspired by Mr Daniel Hindrikes. 

It uses MiJenner.ServicesGeneric Nuget package, source code here: https://github.com/mijenner/MiJenner.ServicesGeneric for an in-memory memory storage. 
