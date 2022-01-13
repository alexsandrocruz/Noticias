const ENV = {
  dev: {
    apiUrl: 'http://localhost:44315',
    oAuthConfig: {
      issuer: 'http://localhost:44315',
      clientId: 'Noticias_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Noticias',
    },
    localization: {
      defaultResourceName: 'Noticias',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44315',
    oAuthConfig: {
      issuer: 'http://localhost:44315',
      clientId: 'Noticias_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Noticias',
    },
    localization: {
      defaultResourceName: 'Noticias',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
