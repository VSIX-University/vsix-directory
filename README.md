# VSIX University

An ambitious endeavor to help educate and provide knowledge to the world of Visual Studio extension developers!

## VSIX Directory

This project will create a suite of services that provide a simple, easy-to-use, front-end search engine to help identify
and surface Visual Studio extension repositories / projects available publicly on GitHub to ease the burden of finding
information manually.

### Phase 1

#### GitHub Search Service / Postgres Database

1. Weekly routine that scours GitHub for filenames = 'source.extension.manifest'
2. Parse results to create a postgres database of "Open Source VSIX projects"

#### API Server

1. Minimal code just to serve the data

#### Client

1. Site allows basic searching through name and description with clean/minimal theme.

### Phase 2

#### GitHub Search / Project "Classifier" Service

1. Roll back through each repository and introspect it for VS feature usage, then tag each repo in the database
  i. I.e., if you find a class that implements `ILanguageClient`, its not far-fetched they are using "LSP"
  i. I.f., if you find a class that implements `IAsyncCodeLensProvider`, its not far-fetched they are using "CodeLens"

#### Other Updates

1. When GitHubScourService finishes, trigger the Classifier Service function
2. Allow searching/filtering via tag

### Challenges

1. Introspecting and detecting individual features - how?
  i. What if the repository is a mono-repo and has tons of other stuff and we classify wrong?
    i. Need a way to "de-classify" a repo/project and associated feature/tag and make sure we don't accidently reclassify it again in the future.
2. Licensing issues?
  i. We're only surfacing the repository/project and not individual lines of code (*cough*CoPilot*cough*), its up to the user to USE it in the appropriate way.