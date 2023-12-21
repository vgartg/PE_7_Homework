#!/bin/bash

. /BashFile.sh

if [ ! $[$(Prod 1 1)==1] ]
then exit 99;
fi

if [ ! $[$(Prod 2 2)==4] ]
then exit 99; 
fi

if [ ! $[$(Prod 0 1234)!=1234] ]
then exit 99;
fi

echo "Tests compeleted!"