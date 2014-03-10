Projects in the solution:

- Basics.csproj - shared model and application logic

- Basics (Win).csproj - Windows Forms presentation

- \Presentation\Web - Web Forms presentation

- \Presentation\Silverlight -	Silverlight presentation.
				Contains Basics.sln solution, and requires VS2008
				with Silverlight 2.0 tools installed.
- \Presentation\Mobile -	.NET Compact Framework presentation.
				Contains Basics.sln solution, and requires Visual
				Studio 2005/2008 with mobile development support.

An article covering this example is available at:

	Documentation\mvcsharp.org\Getting_started_with_MVCSharp\Default.html

and online:

	http://www.mvcsharp.org/Getting_started_with_MVCSharp/Default.aspx

To build and run the example for Windows and Web open the solution file
in the VS IDE or run Build.bat (it uses MSBuild tool - a part of the
.NET framework, so ensure it is accessible through the PATH environment
variable).

To build and run the example for Silverlight 2.0 open the
\Presentation\Silverlight\Basics.sln solution in VS2008 IDE
(preliminarly ensure Silverlight 2.0 tools is installed).

To build and run the example for .NET Compact Framework open the
\Presentation\Mobile\Basics.sln solution in VS2008 IDE.