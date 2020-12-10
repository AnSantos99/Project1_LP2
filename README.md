
# NASA Exoplanet Database

## Authors

**Ana Santos** - a21900297

**Joana Silva** - a21805651

## Work distribution

**Ana Santos**
Main coding in the project. Code logic discussions with group and classmates.
Research, pushed UML to gitHub and added some more information to Report.
Generated DoxygenFile.

**Joana Silva**
Code structure discussion, research, Creation and structure of readme file,
Creation of UML class diagram and Flowchart.


## Used git repository

Git repository located [here](https://github.com/AnSantos99/Project1_LP2).

## Arquitetura da solução

This project is being implemented on interactive console mode. The students
followed the teachers suggestions for the structure of the program by adding
a class for each specific object. Which is in our case ‘Class Planet’ and
‘Class Star’ where both of them implement an interface ‘IAdditionalCamps’ due
to their shared camps.
The students gave their best to respect the SOLID principles but did not
think of a specific design pattern for the constitution of the program.

The program starts off by asking the user the specific files name which has
a predetermined location path to the desktop. If the file presents the wrong
extension or for any reason the program cannot find the obligatory camps on the
file, the program will throw an exception.

There are still features that were not implemented in the project. For example
the application will only show the correct contents with the original file
because the sections are associated with a specific index that is given on the
original file. The program does also not convert numeric fields. Making only
comparison between strings. Making it not possible to search in a numeric
camp a number between x and y. There is also a problem with the displaying of
the Stars content.

The program takes use of LINQ in order to go through all elements and compare
the input of the users with the list that contains the specific substring and
one small query to check whether the specified file contains the mains Camps
(Planet Name and Hostname).
There were mainly used Lists to store the contents of the files and arrays.

Near the end of the deadline, the students started to realize that the Planets
and Stars shared a lot of Properties and similar Methods. Which made us realize
that we could have thought a bit more about the design pattern of the classes
so the application would have become more efficient and easier to understand
in some fields (for example by using more Abstract classes or interfaces for
components that both principle classes (Planets and Stars) shared).

### Flowchart

![Flowchart](Flowchart.png)

### UML class diagram
![UML](UML.png)

## References

### Class Material

* \[1\] Fachada, N (2020). **Aula 06**
* \[2\] Fachada, N (2020). **Aula 08**
* \[3\] LP2, Project 1 (2019). **IMDB Database Project**

### Books

* Albahari, J. (2017). **C# 7.0 in a Nutshell**. O�Reilly Media.

### Website

* \[1\] Alzahabi, H (2017). **How to Process a CSV File with LINQ**.
Retrieved from: <https://www.youtube.com/watch?v=p3m5vNRYn7k>
* \[2\] Kumar, M (2020). **C# | String.Contains() Method**.
Retrieved from: <https://www.geeksforgeeks.org/c-sharp-string-contains-method/>
* \[3\] Programming Starten (2019). **C# LINQ Tutorial**.
Retrieved from: <https://www.youtube.com/watch?v=IUgebK3MHKo>
* \[4\] Microsoft. **Interface ICollection <T>**.
Retrieved from: <https://docs.microsoft.com/de-de/dotnet/api/system.collections.generic.icollection-1?view=netstandard-2.0>
* \[5\] Microsoft. **IOException Class**.
Retrieved from: <https://docs.microsoft.com/en-us/dotnet/api/system.io.ioexception?view=net-5.0>
* \[6\] Jallepalli, K (2020). **Collections in c#**.
Retrieved from: <https://www.c-sharpcorner.com/UploadFile/736bf5/collection-in-C-Sharp/>
* \[7\] Coders Media (2017). **Skip and Select Elements in a String Array using LINQ**. Retrieved from: <https://www.youtube.com/watch?v=ufIfszdaodA>

### Colleagues Input

**Diana Levay - 21801515** Helped us with the Querys and the UserInput from the
user. Which was causing problems by not recognizing the proper contents and
giving NullReferenceExceptions and IndexOutOfRangeExceptions due to
not being able to recognize the proper original list.


**Francisco Pires - 21804873** Helped us by giving us and idea for the project's
structure. (Which we didn't end up using it but helped us in being more open
to different types of approaches).

