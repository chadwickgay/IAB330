# IAB330 Mobile Application Development
#### _Where's My Stuff?_ Xamarin Mobile App
##### Jacob Bradford n9190007
##### Cameron Gartner (n9682091)
##### Chad Gay (n9410392)
##### Jack Manderson (n9473122)

## Installation Instructions
1. Ensure git is setup on your machine, with SSH keys installed.
2. Ensure Visual Studio with Xamarin is setup
3. Clone the repo to your machine. `git clone git@github.com:jakeb1996/iab330.git`
4. Open the solution file `WheresMyStuff.sln`, found in the root directory of the project

## Management
1. Issues are tracked in Trello `https://trello.com/b/yl1ImuZl`. Always assign yourself to the ticket if you are working on it and ensure you move it between the task lists.
2. Merging to `master` requires opening a Pull Request and passing a code review by a non-author
3. Unit testing must be written, with a goal of 100% coverage

## Branching
When creating branches, use the following name prefixes;
- `task` is used for implementing a new feature eg: `task/XA-27_add_create_item`
- `bug` is used for a bug fix eg: `bug/XA-28_fix_create_item_exception_err`
- `release` is used for a constructing a new release `release/v1.0.1`
- _Note:_ 
 -- When a release has been successfully built & tested, merge it into `master` (ie: `master` should always be the latest version that is in the App Store/Play Store [or the base project])
 -- Ensure you start the first line of the commit with the ticket number. This makes it easier to see which ticket a file was last changed in. eg:
```
task/XA-28
- implemented fix by ..
```

## Versioning
The project will follow the Semantic Versioning 2.0.0 standard. See http://semver.org/
- Summary
-- Given a version number MAJOR.MINOR.PATCH, increment the:
--- MAJOR version when you make incompatible API changes,
--- MINOR version when you add functionality in a backwards-compatible manner, and
--- PATCH version when you make backwards-compatible bug fixes.
- Update the version number in the Project Properties -> Android Manifest

## Building a Release
See [Preparing an Application for Release](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/publishing_an_application/part_1_-_preparing_an_application_for_release/#Versioning)