import './loginForm.css'
import React, { useEffect, useState } from 'react'
import { Select, MenuItem, InputLabel } from '@mui/material'

const INIT_FORM = {
  email: '',
  password: '',
  role: '',
}

function LoginForm({ onLogin }) {
  const [form, setForm] = useState(INIT_FORM)

  useEffect(() => {
    setForm(INIT_FORM)
  }, [])


  function changeForm(e) {
    // e.persist()
    console.log(e.target.type)
    setForm(prev => {
      return {
        ...prev,
        [e.target.type]: e.target.value,
      }
    })
  }

  function onSubmit(e) {
    e.preventDefault()
    console.log(form)
    // onLogin(form)
    setForm(INIT_FORM)
  }

  useEffect(() => setForm(INIT_FORM), [])

  return (
    <form onSubmit={onSubmit}>
      <h2>Вход / Регистрация</h2>
      <label>
        Почта
        <input
          className='input'
          type="email"
          value={form.email}
          onChange={changeForm}
          autoComplete='off'
        /></label>
      <label>
        Пароль
        <input
          className='input'
          type="password"
          value={form.password}
          onChange={changeForm}
          autoComplete='off'
        /></label>

      <Select className='input'
        type='role'
        // label='Выберите роль'
        size='small'
        defaultValue={'role'}
        onChange={changeForm}
        required
      >
        <MenuItem value={'role'} type='role' disabled>
          Role
        </MenuItem>
        <MenuItem value={'candidate'} type='role'>
          Соискатель
        </MenuItem>
        <MenuItem value={'employer'} type='role'>
          Работодатель
        </MenuItem>
      </Select >

      <button type="submit">
        Войти
      </button>
    </form >
  )
}

export default LoginForm