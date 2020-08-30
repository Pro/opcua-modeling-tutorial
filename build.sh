#!/usr/bin/env bash

docker run \
	  --mount type=bind,source=$(pwd),target=/model/src \
	  --entrypoint "/app/PublishModel.sh" \
	  sailavid/ua-modelcompiler \
	   /model/src/FooFltModel FooFlt /model/src/Published
