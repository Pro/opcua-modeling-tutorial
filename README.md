# OPC UA Modeling Tutorial

This repository contains additional files for the OPC UA Modeling Tutorial on
https://opcua.rocks/from-modelling-to-execution-opc-ua-information-model-tutorial/

An Example Server based on this Model is provided here:
https://github.com/Pro/opcua-modeling-tutorial-server

## How to use

The `master` branch only contains the `*Model.xml` files, not the compiled NodeSet2.xml files.

On every push to a branch, an is executed and the resulting model files are pushed back to the branch 'master-published'.

Have a look at the resulting files here:
https://github.com/Pro/opcua-modeling-tutorial/tree/master-published/Published

If you like to manually build the files on your machine, follow these steps:

This build process is using a pre-built docker container based on the official UA-ModelCompiler source code.
There's currently an open pull-request (https://github.com/OPCFoundation/UA-ModelCompiler/pull/36) to add the necessary docker files to the official repository. In the meantime you can use my docker container:
[sailavid/ua-modelcompiler](https://cloud.docker.com/u/sailavid/repository/docker/sailavid/ua-modelcompiler).

1. Install docker on your machine
2. Clone this repository
3. `cd skill-nodeset`
4. Then run the provided `build.sh` or the docker container for `FooFltModel`:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/FooFltModel FooFlt /model/src/Published
	```

This will create all the compiled NodeSet2.xml files inside the `Published` folder.
With this command you can also compiler your own model files, just adapt the last line accordingly.
