docker rm ramn-web-container
docker build . -t ramn-web
docker run -it -p 5000:5000 --name ramn-web-container -v "$(pwd)/data:/var/data" -v "$(pwd)/wwwroot/uploads:/app/wwwroot/uploads" -v "$(pwd)/wwwroot/files:/app/wwwroot/files" -e 'RAMNWEB_DB_PATH=/var/data/piranha.db' ramn-web
