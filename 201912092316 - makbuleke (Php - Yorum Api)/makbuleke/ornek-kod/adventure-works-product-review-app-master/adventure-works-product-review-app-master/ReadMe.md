## Adventure Work Product Review Application

#### Prerequisites

* Install npm/Node js
```
   https://github.com/creationix/nvm 
   
   preffered Node version 8.11
```
* Install Aws cli
```
   https://docs.aws.amazon.com/en_us/cli/latest/userguide/install-linux-al2017.html
```

* Install Terraform:
```
  1- wget https://releases.hashicorp.com/terraform/0.11.11/terraform_0.11.11_linux_amd64.zip
  2- unzip terraform_0.11.11_linux_amd64.zip
  3- sudo mv terraform /usr/local/bin/
  4- terraform --version
```

* Install Serverless Framework
```
  npm install -g serverless
```

* Install mysql client
```
   sudo apt-get install mysql-client
```
* Install jq
```
   sudo apt-get install jq
```

#### Deployment

* Get Repo
```
    git clone https://gitlab.com/fatihaydilek/adventure-works-product-review-app.git
    
    cd adventure-works-product-review-app/api/layer/ && npm install
    
```

* Set Bash Variables for deployment
```
    REGION="<select region>"
    
    BUCKET="<select bucket name for tf states>"
    
    PROFILE="<select aws profile>"
     
```

* Create Bucket For Deployment
```
    aws s3api create-bucket --bucket $BUCKET --region $REGION --create-bucket-configuration LocationConstraint=$REGION
    
    if bucket that you selected is already taken, please change BUCKET variable with unique one.
```

* Terraform Deployment ( RDS - VPC )
```
    cd ../../terraform/
    
    terraform init \
    -backend-config="bucket=$BUCKET" \
    -backend-config="region=$REGION" \
    -backend-config="key=$BUCKET"
    
    terraform plan  -var 'aws_region'=$REGION  -var 'aws_profile'=$PROFILE
```

Terraform will show planned changes. If you want apply run command below and type "yes" when asked.

```
    terraform apply  -var 'aws_region'=$REGION  -var 'aws_profile'=$PROFILE
      
```
Write terraform output to feed serverless stack.
```
    terraform output -json > terraformOutput.json
    
    node prepareServerlessConfig.js
```

* DBMigration
```
    cd ../api
    
    mysql -u foo --password=foobarbaz -h $(cat ../terraform/terraformOutput.json | jq -r .rds_endpoint.value) adventureworks < ./layer/dbMigration/AWBackup.sql
    
    mysql -u foo --password=foobarbaz -h $(cat ../terraform/terraformOutput.json | jq -r .rds_endpoint.value) adventureworks < ./layer/dbMigration/patch.sql
```

* Serverless Stack Deployment
```
    serverless deploy 
```



#### Usage
   
* Authorization:
```
    Please add Authorization key to header with value 'Allow'. 'Allow' is dummy token.
```    

* Get Reviews:
```
    curl -X GET \
      < GET endpoint from serverless stack output > \
      -H 'Authorization: Allow' 
```    

* Insert Reviews:
```
   curl -X POST \
     < POST endpoint from severless stack output > \
     -H 'Authorization: Allow' \
     -H 'Content-Type: application/json' \
     -H 'cache-control: no-cache' \
     -d '{
   "name": "Elvis Presley",
   "email": "theking@elvismansion.com",
   "productid": "3",
   "review": "I really love the product and will recommend!"
   }'
   
```    

* Note
```
    if you get output "Message": "User is not authorized to access this resource" from API call.
    Please set authorizer cache ttl to zero and re-deploy API
    
    APIGW -> Authorizers -> Edit -> Authorization Caching Enabled ->  TTL (seconds) = 0 -> deploy api
```   


#### Clean Up

* Remove Serveless Stack:
```
    serverless remove
```

* Remove Serveless Stack:
```
    cd ../terraform
    
    terraform destroy -var 'aws_region'=$REGION  -var 'aws_profile'=$PROFILE
```