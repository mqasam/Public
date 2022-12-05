Write any notes you want to make here. For example, you might want to
tell us how to install any dependencies and run the program you've
written.

Hi, 

First of all I would like to apologise for this taking so long.

I created a console project which I added in newtonsoft for the json serialising and deserialising 

At first which you may see from my commits that the project was not setup correctly, I had slight issues so created another one seperate and just pasted it in.
From this came a fun issue which was the business service ddl was not being created in the bin folder, so for a quick hack I just pasted the dll from the obj into the bin.
This would not be an issue normally as I would resolve this but did not want to waste more time trying to resolve it in this case.

I left some minor notes in the project but I split it out into 3 projects; the main project (console app), business project and test project.
Tests were created first during the project for majority of it but towards the end I did a bulk create of interfaces, the services and the tests as I needed to get it done as soon as possible.

In terms of unit tests, I added a reference to autofixture to create sample data for the output data.

I have not done unit tests in a while and have started up again in my current role but mostly updating current tests and I am going to start a course on unit tests so I can improve this part of my skills.

Theres 3 projects and the main and test one have a reference to the business project.
I could have split the interfaces and services into seperate folder but again for this example I decided to leave them as is but is something I could improve this project on.
The tests also are in one folder and to tidy it up would but into seperate test projects as the project grew as the depencies for vary for each one.

There were certain bits of the output which I may not have done correctly but tried to understand where they were coming from and how it was being built 

Thank you for this opportunity!