// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
    production: false,
    clientId: '0oa16hq9n8LNSgnMu4x7',
    issuer: 'https://dev-881723.okta.com/oauth2/default',
    redirectUri: 'http://localhost:4200/implicit/callback',
    scopes: ['openid', 'profile', 'email'],
    pkce: true
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
