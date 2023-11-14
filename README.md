# CacheRedisApp

This project is an API designed to demonstrate the basic usage of in-memory cache and Redis. The project includes functionalities such as establishing a Redis connection, storing data in Redis, and caching in memory.

## Getting Started

First, clone this project to your machine:

```bash
git clone https://github.com/Yesarib/CacheRedisApp.git 
```
Navigate to the project directory:
```
cd CacheRedisApp
```

When you run Redis server, edit the following fields.
```
 "CacheOptions": {
    "Url": "localhost:6379"
  },
```
These fields contain the connection information needed to communicate with the Redis server. Update the url field according to your own Redis server information.
