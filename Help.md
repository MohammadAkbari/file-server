[Serve static files from docker via nginx](https://www.linkedin.com/pulse/serve-static-files-from-docker-via-nginx-basic-example-arun-kumar/)

[Github repo](https://github.com/arunkumars08/docker-static-files-serve)

```
sudo docker build -t file-server .
sudo docker run -d -p 8000:90 --name fs1 -v /home/rabbit1/files:/usr/share/nginx/html/files file-server
```
--------------------------------------------------------------------------------------------------------

```
sudo docker build -t file-generator:1.0 .
sudo docker run -d -p 8002:80 --name fg1 -v /home/rabbit1/files:/files file-generator:1.0
```
