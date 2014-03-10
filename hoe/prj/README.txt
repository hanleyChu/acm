----------------------------------------------------------------
                   WHERE IS THE FRAMEWORK DLL ?
----------------------------------------------------------------
In order to produce the framework DLL you need to build it from the
source files (it's easy - just one click - see the instructions below).

Note that to yield DLL files for different platforms (Silverlight, Mobile,
Desktop, etc.) different projects should be built.

----------------------------------------------------------------
                        FOLDER STRUCTURE
----------------------------------------------------------------
MVCSharp					- MVC# Framework sources
	\Silverlight					- For Silverlight
	\Moblie						- For .NET CF
MVCSharp.Tests					- NUnit tests
Examples					- examples of using MVC# Framework
	\[Name]\Presentation\Silverlight		- Silverlight versions
	\[Name]\Presentation\Mobile			- .NET CF versions
Documentation					- MVC# documentation

----------------------------------------------------------------
                   BUILDING AND RUNNING PROJECTS
----------------------------------------------------------------
If you have Visual Studio installed you may open the solution files and
compile projects from the IDE.

Alternatively you may run Build.bat files located in the project folders.
Since they make use of the MSBuild tool make sure that .NET framework folder
is included in the PATH environment variable.

----------------------------------------------------------------
                        MORE INFORMATION
----------------------------------------------------------------
You can find MVC# manuals and tutorials at the project website

	www.MVCSharp.org

Documentation is also available offline and located in the "Documentation"
folder. See Documentation\Index.html.

----------------------------------------------------------------
                             LICENSE
----------------------------------------------------------------
This library is licensed under the Microsoft Public License (see License.txt).