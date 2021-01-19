# Accessing docker environment variables in .NET

## Sample docker-compose file

```yml
version: "3.8"

services:
  console-dotnet:
    image: console-dotnet
    container_name: console-dotnet
    build:
        context: .
        dockerfile: ./scratch-1/Dockerfile
    environment:
        - testEnv=HelloEnv
```

## Test getting environment variable declared in docker

`$ docker-compose -f docker-compose-scratch-1.yml up`

```bash
Starting console-dotnet ... done
Attaching to console-dotnet
console-dotnet    | Hello World! testEnv: HelloEnv
```

## Test getting environment variable in Windows

1. Open a command prompt in the project folder
2. Set a temporary environment variable
    i.e. `set testEnv=helloEnv`
3. Run dotnet application via cmd prompt
    `dotnet run`

    Output: `Hello World! testEnv: helloEnv`