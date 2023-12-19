FROM bash:latest
COPY . /var/www/bash
WORKDIR /var/www/bash  
CMD ["bash"]
