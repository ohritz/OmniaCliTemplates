﻿import { Composer, DevelopmentEnvironment } from "@omnia/tooling/composers";

Composer
    .registerManifest("$serviceid$", "$namespace$")
    .registerService({ description: "Description of $namespace$" })
    .AsWebApp()
    .withBuildOptions({
        include: ["client"],
        moduleOptions: {
            enableTransformResourcePath: true
        },
        enableAutoAddManifestDependency: true
    });
    
   