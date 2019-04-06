# How to deploy an ASP.NET Core web app on a Windows virtual machine in Azure

This is a repository to document how I'm learning to build a completely replicable automated deployment from source code to a running application in Azure.

**This repo is a work in progress.**

There will be a simple F# app in this directory and some config files to provision infrastructure.

Infrastructure is created with [Azure Resource Manager templates](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-overview#template-deployment).

Provisioning is done using a [Custom Script Extension](https://docs.microsoft.com/en-us/azure/virtual-machines/extensions/custom-script-windows) and the app will be deployed as a [Windows Service](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service?view=aspnetcore-2.2).

Extras:

* use Azure Pipelines to build, test and deploy the app ([deployment guide on IIS](https://docs.microsoft.com/en-us/azure/devops/pipelines/apps/cd/deploy-webdeploy-iis-deploygroups?view=azure-devops))
