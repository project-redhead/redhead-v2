import React from 'react';
import AuthService from '../../common/services/auth';

const LoginPage = () => {
	AuthService.redirectToLogin();
	return (<span>Redirecting...</span>);
}

export default LoginPage;
