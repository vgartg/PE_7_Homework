FROM bash:latest
COPY . /bash
WORKDIR /bash
CMD ["bash", "BashFile.sh"]