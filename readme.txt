The code contained in this project is NOT something I ended up using in the
Assignment project the folks over at Nude Solutions want me to create for them.
So after thinking about it, I ended up deciding to change direction and go down 
the more traditional path. 

The inspiration for this code came from a Udemy instructor (Tim Correy) and he
made some compelling arguments for why this sort of approach was taken for a
custom Repository pattern and that was when someone starts up a ASP.NET MVC
project in Visual Studio, both the entity as well as the view models are
tightly coupled together. As a seasoned Java Developer but someone new to
ASP.NET, this got my attention. However after a day of reflecting on what 
the code base uses (it achieves its ORM goals through using Stored Procedures), 
I decided to abandon it and instead use the ASP.NET Framework. Plus while
yes out of the box Visual Studio does bundle the view and entity models
close together, it does not take that much effort to properly separate them 
from each other and yet still have access to the ASP.NET Framework.

If you have some time, give it a looksee. It is an interesting approach
to a custom Repository pattern using Dapper to load and save data.
