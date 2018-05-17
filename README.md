# Kubernetes-Demo

1. Open a terminal at the Kubernetes.Test app directory.
2. Run `docker build . --tag test-app`. This will build a docker image of the .NetCore app.
3. Run `docker tag test-app vbcontainerregistry.azurecr.io/test-app`. This will tag the image, which prepares it to be pushed to the private docker repository.
4. Run `docker login vbcontainerregistry.azurecr.io -u <username> -p <password>`. This will log your computer into the private repository. Username and password can be found in the Azure portal (under the _container-registry_ resource group, _VBContainerRegistry_ resource, and _Access Keys_ tab).
5. Run `docker push vbcontainerregistry.azurecr.io/test-app`. This will push the docker image to the private repository. You can view it in the portal in the _Repositories_ tab, under the _VBContainerRegistry_ resource.
6. Run `kubectl create -f Deploy.yaml`. This will deploy the docker image to the Kubernetes cluster (you must have kubernetes-cli installed, azure-cli installed, and you must be connected to the Kubernetes cluster. This info can be found on the Configuration-Kong repository in Github). The cluster found in the dev-k8s-sandbox-centralus resource group should be used for this.
7. Run `kubectl get pods -n test-app-ns` to verify that 3 pods are running for the app.
8. Run `kubectl get services -n test-app-ns`. Copy the value for External-IP. This is the IP address you will use to connect to the app from your browser. 
9. Navigate to `http://<IP-Address>/api/MachineName` and you will see that it returns the pod name. <strong>Note:</strong> if you refresh the browser you will receive the same pod name.
10. To view how load balancing works in Kubernetes, run the ConsoleSpammer. Make sure to update the IP address in the ConsoleSpammer.
