import React from 'react';
import AuthService from '../../common/services/auth';

const LoginPage = () => {
	AuthService.redirectToLogin();
}

export default LoginPage;
