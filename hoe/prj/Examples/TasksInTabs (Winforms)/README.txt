This is an example of how MVC# tasks could be hosted each in a different
page of a single tab control (under Winforms UI platform).

The key class in the example is the TasksInTabsViewsManager class -
a WinformsViewsManager descendant with overriden behavior which causes
tasks to reside inside tabs of the main form.