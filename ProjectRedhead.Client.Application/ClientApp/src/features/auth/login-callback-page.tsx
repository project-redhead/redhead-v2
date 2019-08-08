import React from 'react';
import AuthService from '../../common/services/auth';
import { Redirect } from 'react-router';

const LoginCallbackPage = () => {

	let token = new URLSearchParams(window.location.search).get('token');
	AuthService.setToken(token as string);

	return (
		<>
			<span>Signing you in...</span>
			<Redirect to="/" />
		</>
	);
};

export default LoginCallbackPage;
